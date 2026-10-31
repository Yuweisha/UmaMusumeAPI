using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.DTO;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaAController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MetaAController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MetaA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaA>>> GetMetaA()
        {
            return await _context.MetaAs.ToListAsync();
        }

        // GET: api/MetaA/5
        [HttpGet("{i}")]
        public async Task<ActionResult<MetaA>> GetMetaA(int i)
        {
            var metaA = await _context.MetaAs.FindAsync(i);

            if (metaA == null)
            {
                return NotFound();
            }

            return metaA;
        }

        // GET: api/MetaA/hash/3ZMAPBNSMZ3KZXHHISGOZHTSIGBZYB5L
        // 只返回解密需要的两个字段，供 UmaViewer 之类的工具按资源 hash 查密钥。
        [HttpGet("hash/{h}")]
        public async Task<ActionResult<MetaKeyDto>> GetKeyByHash(string h)
        {
            if (string.IsNullOrWhiteSpace(h))
            {
                return BadRequest("hash is required");
            }

            var metaA = await _context.MetaAs
                .AsNoTracking()
                .Where(x => x.H == h)
                .Select(x => new MetaKeyDto { H = x.H, N = x.N, E = x.E })
                .FirstOrDefaultAsync();

            if (metaA == null)
            {
                return NotFound();
            }

            return metaA;
        }

        // GET: api/MetaA/keys?skip=0&take=1000
        // 分页导出 (hash, key)，方便工具批量同步；take 上限 5000。
        [HttpGet("keys")]
        public async Task<ActionResult<IEnumerable<MetaKeyDto>>> GetKeys(int skip = 0, int take = 1000)
        {
            if (skip < 0) skip = 0;
            if (take <= 0 || take > 5000) take = 1000;

            var rows = await _context.MetaAs
                .AsNoTracking()
                .Where(x => x.E != null && x.E != 0)
                .OrderBy(x => x.I)
                .Skip(skip)
                .Take(take)
                .Select(x => new MetaKeyDto { H = x.H, N = x.N, E = x.E })
                .ToListAsync();

            return rows;
        }
    }
}
