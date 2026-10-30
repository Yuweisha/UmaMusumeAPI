using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Context
{
    public partial class UmaMusumeDbContext
    {
        public virtual DbSet<CampaignTargetScenario> CampaignTargetScenarios { get; set; }
        public virtual DbSet<CardTalentLevelUpgradeItem> CardTalentLevelUpgradeItems { get; set; }
        public virtual DbSet<CardTalentLevelUpgradeMoney> CardTalentLevelUpgradeMoneys { get; set; }
        public virtual DbSet<CardTalentUpgradeMoneyNum> CardTalentUpgradeMoneyNums { get; set; }
        public virtual DbSet<CharaTypeEventCut> CharaTypeEventCuts { get; set; }
        public virtual DbSet<CharacterPropSystemText> CharacterPropSystemTexts { get; set; }
        public virtual DbSet<CollectRaidMessage> CollectRaidMessages { get; set; }
        public virtual DbSet<CollectRaidTopRandomCharaGroup> CollectRaidTopRandomCharaGroups { get; set; }
        public virtual DbSet<ConstantWalkingData> ConstantWalkingDatas { get; set; }
        public virtual DbSet<DressLiveLimited> DressLiveLimiteds { get; set; }
        public virtual DbSet<FactorResearchTaskData> FactorResearchTaskDatas { get; set; }
        public virtual DbSet<FactorResearchTaskList> FactorResearchTaskLists { get; set; }
        public virtual DbSet<FactorResearchTaskPointReward> FactorResearchTaskPointRewards { get; set; }
        public virtual DbSet<FactorResearchWhiteFactorItem> FactorResearchWhiteFactorItems { get; set; }
        public virtual DbSet<GachaCardAdditionNum> GachaCardAdditionNums { get; set; }
        public virtual DbSet<GachaItemExchange> GachaItemExchanges { get; set; }
        public virtual DbSet<GachaStampsheet> GachaStampsheets { get; set; }
        public virtual DbSet<GachaStampsheetReward> GachaStampsheetRewards { get; set; }
        public virtual DbSet<GenerateSuccessionTrainedCharaTradeItem> GenerateSuccessionTrainedCharaTradeItems { get; set; }
        public virtual DbSet<HeroesRankingBorder> HeroesRankingBorders { get; set; }
        public virtual DbSet<HeroesRankingReward> HeroesRankingRewards { get; set; }
        public virtual DbSet<HideCharaTextScenario> HideCharaTextScenarios { get; set; }
        public virtual DbSet<HideCharaTextSpecial> HideCharaTextSpecials { get; set; }
        public virtual DbSet<HomeWalkPathRestriction> HomeWalkPathRestrictions { get; set; }
        public virtual DbSet<IdleSingleModeTrainingCut> IdleSingleModeTrainingCuts { get; set; }
        public virtual DbSet<ItemPack> ItemPacks { get; set; }
        public virtual DbSet<JobsLimitedSchedule> JobsLimitedSchedules { get; set; }
        public virtual DbSet<LiveDressRestrictData> LiveDressRestrictDatas { get; set; }
        public virtual DbSet<LiveFixMemberData> LiveFixMemberDatas { get; set; }
        public virtual DbSet<LiveRecommendFormation> LiveRecommendFormations { get; set; }
        public virtual DbSet<MainStoryCustomLoad> MainStoryCustomLoads { get; set; }
        public virtual DbSet<MemoryData> MemoryDatas { get; set; }
        public virtual DbSet<NicknameHide> NicknameHides { get; set; }
        public virtual DbSet<OmakaseBasePt> OmakaseBasePts { get; set; }
        public virtual DbSet<OmakaseBasePtOnsen> OmakaseBasePtOnsens { get; set; }
        public virtual DbSet<OmakaseCommand> OmakaseCommands { get; set; }
        public virtual DbSet<OmakaseConditionSet> OmakaseConditionSets { get; set; }
        public virtual DbSet<OmakaseConditionSetOnsen> OmakaseConditionSetOnsens { get; set; }
        public virtual DbSet<OmakaseContinueCondition> OmakaseContinueConditions { get; set; }
        public virtual DbSet<OmakaseDefaultPlan> OmakaseDefaultPlans { get; set; }
        public virtual DbSet<OmakaseDefaultPlanSet> OmakaseDefaultPlanSets { get; set; }
        public virtual DbSet<OmakaseFilter> OmakaseFilters { get; set; }
        public virtual DbSet<OmakaseFilterDetail> OmakaseFilterDetails { get; set; }
        public virtual DbSet<OmakaseHideSkill> OmakaseHideSkills { get; set; }
        public virtual DbSet<OmakaseModify> OmakaseModifys { get; set; }
        public virtual DbSet<OmakaseModifyLegend> OmakaseModifyLegends { get; set; }
        public virtual DbSet<OmakaseModifyPt> OmakaseModifyPts { get; set; }
        public virtual DbSet<OmakaseOutingBasePt> OmakaseOutingBasePts { get; set; }
        public virtual DbSet<OmakaseScenario> OmakaseScenarios { get; set; }
        public virtual DbSet<OmakaseState> OmakaseStates { get; set; }
        public virtual DbSet<OmakaseStopCondition> OmakaseStopConditions { get; set; }
        public virtual DbSet<OmakaseStopTrigger> OmakaseStopTriggers { get; set; }
        public virtual DbSet<OmakaseStopperEvent> OmakaseStopperEvents { get; set; }
        public virtual DbSet<RaceSpRuleData> RaceSpRuleDatas { get; set; }
        public virtual DbSet<RaceSpRuleSchedule> RaceSpRuleSchedules { get; set; }
        public virtual DbSet<RaceSpRuleSkillset> RaceSpRuleSkillsets { get; set; }
        public virtual DbSet<RentalDeck> RentalDecks { get; set; }
        public virtual DbSet<RentalDeckAlt> RentalDeckAlts { get; set; }
        public virtual DbSet<RentalDeckCard> RentalDeckCards { get; set; }
        public virtual DbSet<ShopBanner> ShopBanners { get; set; }
        public virtual DbSet<SingleMode109047Reward> SingleMode109047Rewards { get; set; }
        public virtual DbSet<SingleMode109048Bonus> SingleMode109048Bonuss { get; set; }
        public virtual DbSet<SingleMode109048Guest> SingleMode109048Guests { get; set; }
        public virtual DbSet<SingleMode10AudienceEffect> SingleMode10AudienceEffects { get; set; }
        public virtual DbSet<SingleMode10Buff> SingleMode10Buffs { get; set; }
        public virtual DbSet<SingleMode10BuffCondition> SingleMode10BuffConditions { get; set; }
        public virtual DbSet<SingleMode10BuffEffect> SingleMode10BuffEffects { get; set; }
        public virtual DbSet<SingleMode10BuffNum> SingleMode10BuffNums { get; set; }
        public virtual DbSet<SingleMode10CmDetail> SingleMode10CmDetails { get; set; }
        public virtual DbSet<SingleMode10GroupOutingEff> SingleMode10GroupOutingEffs { get; set; }
        public virtual DbSet<SingleMode10LotteryTurn> SingleMode10LotteryTurns { get; set; }
        public virtual DbSet<SingleMode10Masterly> SingleMode10Masterlys { get; set; }
        public virtual DbSet<SingleMode10Sprace> SingleMode10Spraces { get; set; }
        public virtual DbSet<SingleMode10StagingSound> SingleMode10StagingSounds { get; set; }
        public virtual DbSet<SingleMode11CheckPointEff> SingleMode11CheckPointEffs { get; set; }
        public virtual DbSet<SingleMode11FacilityEffect> SingleMode11FacilityEffects { get; set; }
        public virtual DbSet<SingleMode11FacilityKind> SingleMode11FacilityKinds { get; set; }
        public virtual DbSet<SingleMode11FacilityLvUp> SingleMode11FacilityLvUps { get; set; }
        public virtual DbSet<SingleMode11FacilityState> SingleMode11FacilityStates { get; set; }
        public virtual DbSet<SingleMode11GainTrainingPt> SingleMode11GainTrainingPts { get; set; }
        public virtual DbSet<SingleMode11OutingEffect> SingleMode11OutingEffects { get; set; }
        public virtual DbSet<SingleMode11PioneerPtBonus> SingleMode11PioneerPtBonuss { get; set; }
        public virtual DbSet<SingleMode11Planning> SingleMode11Plannings { get; set; }
        public virtual DbSet<SingleMode11ShimaEffect> SingleMode11ShimaEffects { get; set; }
        public virtual DbSet<SingleMode11TrainingMini> SingleMode11TrainingMinis { get; set; }
        public virtual DbSet<SingleMode12AssistantEffect> SingleMode12AssistantEffects { get; set; }
        public virtual DbSet<SingleMode12CheckDugResult> SingleMode12CheckDugResults { get; set; }
        public virtual DbSet<SingleMode12DigBonus> SingleMode12DigBonuss { get; set; }
        public virtual DbSet<SingleMode12DigItem> SingleMode12DigItems { get; set; }
        public virtual DbSet<SingleMode12DigPower> SingleMode12DigPowers { get; set; }
        public virtual DbSet<SingleMode12DigPowerRank> SingleMode12DigPowerRanks { get; set; }
        public virtual DbSet<SingleMode12EffectCategory> SingleMode12EffectCategorys { get; set; }
        public virtual DbSet<SingleMode12FactorBonus> SingleMode12FactorBonuss { get; set; }
        public virtual DbSet<SingleMode12Onsen> SingleMode12Onsens { get; set; }
        public virtual DbSet<SingleMode12OnsenEffect> SingleMode12OnsenEffects { get; set; }
        public virtual DbSet<SingleMode12OutingEffect> SingleMode12OutingEffects { get; set; }
        public virtual DbSet<SingleMode12RyokanRank> SingleMode12RyokanRanks { get; set; }
        public virtual DbSet<SingleMode12Schedule> SingleMode12Schedules { get; set; }
        public virtual DbSet<SingleMode12SpaTicket> SingleMode12SpaTickets { get; set; }
        public virtual DbSet<SingleMode12Stratum> SingleMode12Stratums { get; set; }
        public virtual DbSet<SingleMode13AddDreamPoint> SingleMode13AddDreamPoints { get; set; }
        public virtual DbSet<SingleMode13BcProgramFlag> SingleMode13BcProgramFlags { get; set; }
        public virtual DbSet<SingleMode13Member> SingleMode13Members { get; set; }
        public virtual DbSet<SingleMode13Rank> SingleMode13Ranks { get; set; }
        public virtual DbSet<SingleMode13RankBonusEffectGroup> SingleMode13RankBonusEffectGroups { get; set; }
        public virtual DbSet<SingleMode13Schedule> SingleMode13Schedules { get; set; }
        public virtual DbSet<SingleMode13TeamRank> SingleMode13TeamRanks { get; set; }
        public virtual DbSet<SingleMode13TeamSpEffect> SingleMode13TeamSpEffects { get; set; }
        public virtual DbSet<SingleMode13TeamSpLevel> SingleMode13TeamSpLevels { get; set; }
        public virtual DbSet<SingleMode13TopBgChara> SingleMode13TopBgCharas { get; set; }
        public virtual DbSet<SingleMode14BasicEffect> SingleMode14BasicEffects { get; set; }
        public virtual DbSet<SingleMode14CheckPoint> SingleMode14CheckPoints { get; set; }
        public virtual DbSet<SingleMode14CheckPointEffect> SingleMode14CheckPointEffects { get; set; }
        public virtual DbSet<SingleMode14CheckPointPt> SingleMode14CheckPointPts { get; set; }
        public virtual DbSet<SingleMode14CheckPointPtEffect> SingleMode14CheckPointPtEffects { get; set; }
        public virtual DbSet<SingleMode14DeckInfo> SingleMode14DeckInfos { get; set; }
        public virtual DbSet<SingleMode14FeelingBonus> SingleMode14FeelingBonuss { get; set; }
        public virtual DbSet<SingleMode14FinalsEffect> SingleMode14FinalsEffects { get; set; }
        public virtual DbSet<SingleMode14FinalsGainSkill> SingleMode14FinalsGainSkills { get; set; }
        public virtual DbSet<SingleMode14OutingEffect> SingleMode14OutingEffects { get; set; }
        public virtual DbSet<SingleMode14RegionEffect> SingleMode14RegionEffects { get; set; }
        public virtual DbSet<SingleMode14RegionEffectBonus> SingleMode14RegionEffectBonuss { get; set; }
        public virtual DbSet<SingleMode14RegionFeeling> SingleMode14RegionFeelings { get; set; }
        public virtual DbSet<SingleMode14RegionSelect> SingleMode14RegionSelects { get; set; }
        public virtual DbSet<SingleMode14SpecialGainTurn> SingleMode14SpecialGainTurns { get; set; }
        public virtual DbSet<SingleMode14TwinkleRamen> SingleMode14TwinkleRamens { get; set; }
        public virtual DbSet<SingleMode15ActEffect> SingleMode15ActEffects { get; set; }
        public virtual DbSet<SingleMode15ActInfo> SingleMode15ActInfos { get; set; }
        public virtual DbSet<SingleMode15ActMember> SingleMode15ActMembers { get; set; }
        public virtual DbSet<SingleMode15Advice> SingleMode15Advices { get; set; }
        public virtual DbSet<SingleMode15AdviceEffect> SingleMode15AdviceEffects { get; set; }
        public virtual DbSet<SingleMode15AdviceRecommend> SingleMode15AdviceRecommends { get; set; }
        public virtual DbSet<SingleMode15CheckPointEffect> SingleMode15CheckPointEffects { get; set; }
        public virtual DbSet<SingleMode15FinalsActEffect> SingleMode15FinalsActEffects { get; set; }
        public virtual DbSet<SingleMode15FusionEffect> SingleMode15FusionEffects { get; set; }
        public virtual DbSet<SingleMode15OutingEffect> SingleMode15OutingEffects { get; set; }
        public virtual DbSet<SingleMode15Schedule> SingleMode15Schedules { get; set; }
        public virtual DbSet<SingleModeAudienceOverwrite> SingleModeAudienceOverwrites { get; set; }
        public virtual DbSet<SingleModeEventChoiceReward> SingleModeEventChoiceRewards { get; set; }
        public virtual DbSet<SingleModeEventCrPriority> SingleModeEventCrPrioritys { get; set; }
        public virtual DbSet<SingleModeHideStoryControl> SingleModeHideStoryControls { get; set; }
        public virtual DbSet<SingleModeRaceUniqueCondition> SingleModeRaceUniqueConditions { get; set; }
        public virtual DbSet<SingleModeSelectSkip> SingleModeSelectSkips { get; set; }
        public virtual DbSet<SingleModeStoryConditionSet> SingleModeStoryConditionSets { get; set; }
        public virtual DbSet<SingleModeStoryRoot> SingleModeStoryRoots { get; set; }
        public virtual DbSet<SkillUpgradeSuccessionSkill> SkillUpgradeSuccessionSkills { get; set; }
        public virtual DbSet<SqliteStat1> SqliteStat1s { get; set; }
        public virtual DbSet<StoryCharaUniqueDiffType> StoryCharaUniqueDiffTypes { get; set; }
        public virtual DbSet<StoryExtraEventMovie> StoryExtraEventMovies { get; set; }
        public virtual DbSet<StoryRaceTrackBgReplace> StoryRaceTrackBgReplaces { get; set; }
        public virtual DbSet<SubscriptionTotalReward> SubscriptionTotalRewards { get; set; }
        public virtual DbSet<SuccessionFactorAddonEffect> SuccessionFactorAddonEffects { get; set; }
        public virtual DbSet<SystemVoiceStandbyMotion> SystemVoiceStandbyMotions { get; set; }
        public virtual DbSet<TrainerSkill> TrainerSkills { get; set; }
        public virtual DbSet<TrainingChallengeRankingBorder> TrainingChallengeRankingBorders { get; set; }
        public virtual DbSet<TrainingChallengeRankingReward> TrainingChallengeRankingRewards { get; set; }
        public virtual DbSet<TrainingReportLoopReward> TrainingReportLoopRewards { get; set; }
        public virtual DbSet<UltimateRaceUnlockCondition> UltimateRaceUnlockConditions { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignTargetScenario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("campaign_target_scenario");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TargetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_id");
                entity.Property(e => e.SingleModeScenarioGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("single_mode_scenario_group_id");
            });
            modelBuilder.Entity<CardTalentLevelUpgradeItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("card_talent_level_upgrade_item");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TalentGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_group_id");
                entity.Property(e => e.TalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_level");
                entity.Property(e => e.UpgradeTalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("upgrade_talent_level");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_3");
                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_3");
                entity.Property(e => e.ItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_3");
                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_4");
                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_4");
                entity.Property(e => e.ItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_4");
                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_5");
                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_5");
                entity.Property(e => e.ItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_5");
                entity.Property(e => e.ItemCategory6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_6");
                entity.Property(e => e.ItemId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_6");
                entity.Property(e => e.ItemNum6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_6");
                entity.Property(e => e.ItemCategory7)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_7");
                entity.Property(e => e.ItemId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_7");
                entity.Property(e => e.ItemNum7)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_7");
                entity.Property(e => e.ItemCategory8)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_8");
                entity.Property(e => e.ItemId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_8");
                entity.Property(e => e.ItemNum8)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_8");
                entity.Property(e => e.ItemCategory9)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_9");
                entity.Property(e => e.ItemId9)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_9");
                entity.Property(e => e.ItemNum9)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_9");
                entity.Property(e => e.ItemCategory10)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_10");
                entity.Property(e => e.ItemId10)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_10");
                entity.Property(e => e.ItemNum10)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_10");
                entity.Property(e => e.ItemCategory11)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_11");
                entity.Property(e => e.ItemId11)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_11");
                entity.Property(e => e.ItemNum11)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_11");
                entity.Property(e => e.ItemCategory12)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_12");
                entity.Property(e => e.ItemId12)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_12");
                entity.Property(e => e.ItemNum12)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_12");
                entity.Property(e => e.ItemCategory13)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_13");
                entity.Property(e => e.ItemId13)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_13");
                entity.Property(e => e.ItemNum13)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_13");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });
            modelBuilder.Entity<CardTalentLevelUpgradeMoney>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("card_talent_level_upgrade_money");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_level");
                entity.Property(e => e.UpgradeTalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("upgrade_talent_level");
                entity.Property(e => e.MoneyNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("money_num");
            });
            modelBuilder.Entity<CardTalentUpgradeMoneyNum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("card_talent_upgrade_money_num");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_level");
                entity.Property(e => e.MoneyNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("money_num");
            });
            modelBuilder.Entity<CharaTypeEventCut>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("chara_type_event_cut");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EventCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_category");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.CutSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_sub_id");
                entity.Property(e => e.MotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_type");
            });
            modelBuilder.Entity<CharacterPropSystemText>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("character_prop_system_text");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id");
                entity.Property(e => e.LipSyncData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lip_sync_data");
            });
            modelBuilder.Entity<CollectRaidMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("collect_raid_message");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CollectRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_raid_id");
                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");
            });
            modelBuilder.Entity<CollectRaidTopRandomCharaGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("collect_raid_top_random_chara_group");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
            });
            modelBuilder.Entity<ConstantWalkingData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("constant_walking_data");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.StartTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_time");
            });
            modelBuilder.Entity<DressLiveLimited>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("dress_live_limited");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
            });
            modelBuilder.Entity<FactorResearchTaskData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("factor_research_task_data");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FactorResearchEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_event_id");
                entity.Property(e => e.AllFactorItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("all_factor_item_id");
                entity.Property(e => e.WhiteFactorItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("white_factor_item_id");
                entity.Property(e => e.PresenMotionChangePoint1)
                    .HasColumnType("int(11)")
                    .HasColumnName("presen_motion_change_point1");
                entity.Property(e => e.PresenMotionChangePoint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("presen_motion_change_point2");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
            });
            modelBuilder.Entity<FactorResearchTaskList>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("factor_research_task_list");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FactorResearchEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_event_id");
                entity.Property(e => e.TaskType)
                    .HasColumnType("int(11)")
                    .HasColumnName("task_type");
                entity.Property(e => e.LogicType)
                    .HasColumnType("int(11)")
                    .HasColumnName("logic_type");
                entity.Property(e => e.Condition1LineCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_line_count");
                entity.Property(e => e.Condition1Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_type");
                entity.Property(e => e.Condition1Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value1");
                entity.Property(e => e.Condition1Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value2");
                entity.Property(e => e.Condition1Value3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value3");
                entity.Property(e => e.Condition1Value4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value4");
                entity.Property(e => e.Condition1Value5)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value5");
                entity.Property(e => e.Condition1Value6)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value6");
                entity.Property(e => e.Condition1Value7)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value7");
                entity.Property(e => e.Condition2LineCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_line_count");
                entity.Property(e => e.Condition2Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_type");
                entity.Property(e => e.Condition2Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value1");
                entity.Property(e => e.Condition2Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value2");
                entity.Property(e => e.Condition2Value3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value3");
                entity.Property(e => e.Condition2Value4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value4");
                entity.Property(e => e.Condition2Value5)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value5");
                entity.Property(e => e.Condition2Value6)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value6");
                entity.Property(e => e.Condition2Value7)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value7");
                entity.Property(e => e.Condition3LineCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_line_count");
                entity.Property(e => e.Condition3Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_type");
                entity.Property(e => e.Condition3Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value1");
                entity.Property(e => e.Condition3Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value2");
                entity.Property(e => e.Condition3Value3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value3");
                entity.Property(e => e.Condition3Value4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value4");
                entity.Property(e => e.Condition3Value5)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value5");
                entity.Property(e => e.Condition3Value6)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value6");
                entity.Property(e => e.Condition3Value7)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value7");
                entity.Property(e => e.Condition4LineCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_line_count");
                entity.Property(e => e.Condition4Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_type");
                entity.Property(e => e.Condition4Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value1");
                entity.Property(e => e.Condition4Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value2");
                entity.Property(e => e.Condition4Value3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value3");
                entity.Property(e => e.Condition4Value4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value4");
                entity.Property(e => e.Condition4Value5)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value5");
                entity.Property(e => e.Condition4Value6)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value6");
                entity.Property(e => e.Condition4Value7)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value7");
                entity.Property(e => e.Condition5LineCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_line_count");
                entity.Property(e => e.Condition5Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_type");
                entity.Property(e => e.Condition5Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value1");
                entity.Property(e => e.Condition5Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value2");
                entity.Property(e => e.Condition5Value3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value3");
                entity.Property(e => e.Condition5Value4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value4");
                entity.Property(e => e.Condition5Value5)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value5");
                entity.Property(e => e.Condition5Value6)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value6");
                entity.Property(e => e.Condition5Value7)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value7");
                entity.Property(e => e.ResearchPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("research_point");
            });
            modelBuilder.Entity<FactorResearchTaskPointReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("factor_research_task_point_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FactorResearchEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_event_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.PickupFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("pickup_flag");
                entity.Property(e => e.RewardPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_point");
            });
            modelBuilder.Entity<FactorResearchWhiteFactorItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("factor_research_white_factor_item");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.FactorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_id");
                entity.Property(e => e.LabelType)
                    .HasColumnType("int(11)")
                    .HasColumnName("label_type");
            });
            modelBuilder.Entity<GachaCardAdditionNum>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.GachaId }).HasName("PRIMARY");
                entity.ToTable("gacha_card_addition_num");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.AdditionalNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_num");
            });
            modelBuilder.Entity<GachaItemExchange>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.GachaId }).HasName("PRIMARY");
                entity.ToTable("gacha_item_exchange");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.PayItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_item_num");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
            });
            modelBuilder.Entity<GachaStampsheet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("gacha_stampsheet");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");
                entity.Property(e => e.SheetNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("sheet_num");
                entity.Property(e => e.IsLoop)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_loop");
                entity.Property(e => e.StampsheetRewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stampsheet_reward_group_id");
                entity.Property(e => e.StampsheetOddsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stampsheet_odds_group_id");
            });
            modelBuilder.Entity<GachaStampsheetReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("gacha_stampsheet_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.RewardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_type");
                entity.Property(e => e.RewardOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_order");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });
            modelBuilder.Entity<GenerateSuccessionTrainedCharaTradeItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("generate_succession_trained_chara_trade_item");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MinValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_value");
                entity.Property(e => e.MaxValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_value");
                entity.Property(e => e.TradeItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("trade_item_category");
                entity.Property(e => e.TradeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("trade_item_id");
                entity.Property(e => e.TradeItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("trade_item_num");
            });
            modelBuilder.Entity<HeroesRankingBorder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("heroes_ranking_border");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RankStart)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_start");
                entity.Property(e => e.RankEnd)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_end");
            });
            modelBuilder.Entity<HeroesRankingReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("heroes_ranking_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.HeroesId)
                    .HasColumnType("int(11)")
                    .HasColumnName("heroes_id");
                entity.Property(e => e.HeroesRankingBorderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("heroes_ranking_border_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });
            modelBuilder.Entity<HideCharaTextScenario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("hide_chara_text_scenario");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.Period)
                    .HasColumnType("int(11)")
                    .HasColumnName("period");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.VoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_id");
            });
            modelBuilder.Entity<HideCharaTextSpecial>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("hide_chara_text_special");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SpecialVoiceExceptId)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_voice_except_id");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.VoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_id");
            });
            modelBuilder.Entity<HomeWalkPathRestriction>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("home_walk_path_restriction");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("route");
            });
            modelBuilder.Entity<IdleSingleModeTrainingCut>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("idle_single_mode_training_cut");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.MaxTrainingLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_training_lv");
                entity.Property(e => e.DesignatedCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("designated_chara_id");
            });
            modelBuilder.Entity<ItemPack>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("item_pack");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemPackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_pack_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
            });
            modelBuilder.Entity<JobsLimitedSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("jobs_limited_schedule");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.EndingDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_date");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
            });
            modelBuilder.Entity<LiveDressRestrictData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("live_dress_restrict_data");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
            });
            modelBuilder.Entity<LiveFixMemberData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("live_fix_member_data");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DressId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id1");
                entity.Property(e => e.DressId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id2");
                entity.Property(e => e.DressColor1)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color1");
                entity.Property(e => e.DressColor2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color2");
            });
            modelBuilder.Entity<LiveRecommendFormation>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("live_recommend_formation");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.PositionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("position_id");
                entity.Property(e => e.CharaType)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_type");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.DressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color");
                entity.Property(e => e.SecondDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("second_dress_id");
                entity.Property(e => e.SecondDressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("second_dress_color");
            });
            modelBuilder.Entity<MainStoryCustomLoad>(entity =>
            {
                entity.HasKey(e => new { e.MainStoryDataId, e.StoryTypeOrder, e.CustomLoadType }).HasName("PRIMARY");
                entity.ToTable("main_story_custom_load");
                entity.Property(e => e.MainStoryDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_story_data_id");
                entity.Property(e => e.StoryTypeOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_order");
                entity.Property(e => e.CustomLoadType)
                    .HasColumnType("int(11)")
                    .HasColumnName("custom_load_type");
                entity.Property(e => e.KeepCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("keep_cue_name");
                entity.Property(e => e.CustomLoadEffectPattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("custom_load_effect_pattern");
                entity.Property(e => e.ImageEffectAssetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_effect_asset_name");
                entity.Property(e => e.UseActionCue)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_action_cue");
                entity.Property(e => e.WaitTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("wait_time");
                entity.Property(e => e.TargetStoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_story_id");
            });
            modelBuilder.Entity<MemoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("memory_data");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
            });
            modelBuilder.Entity<NicknameHide>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("nickname_hide");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NicknameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("nickname_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
            });
            modelBuilder.Entity<OmakaseBasePt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_base_pt");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.AddValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value");
            });
            modelBuilder.Entity<OmakaseBasePtOnsen>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_base_pt_onsen");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.AddValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value");
            });
            modelBuilder.Entity<OmakaseCommand>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("omakase_command");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.SettingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("setting_id");
                entity.Property(e => e.BaseWeight)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_weight");
            });
            modelBuilder.Entity<OmakaseConditionSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_condition_set");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value2");
            });
            modelBuilder.Entity<OmakaseConditionSetOnsen>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_condition_set_onsen");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value2");
            });
            modelBuilder.Entity<OmakaseContinueCondition>(entity =>
            {
                entity.HasKey(e => e.ContinueConditionId).HasName("PRIMARY");
                entity.ToTable("omakase_continue_condition");
                entity.Property(e => e.ContinueConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("continue_condition_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });
            modelBuilder.Entity<OmakaseDefaultPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId).HasName("PRIMARY");
                entity.ToTable("omakase_default_plan");
                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id");
                entity.Property(e => e.PlanCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_chara_id");
                entity.Property(e => e.PlanSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_set_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });
            modelBuilder.Entity<OmakaseDefaultPlanSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_default_plan_set");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PlanSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_set_id");
                entity.Property(e => e.PlanSetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_set_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
            });
            modelBuilder.Entity<OmakaseFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId).HasName("PRIMARY");
                entity.ToTable("omakase_filter");
                entity.Property(e => e.FilterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("filter_id");
                entity.Property(e => e.IsModifiable)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_modifiable");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
            });
            modelBuilder.Entity<OmakaseFilterDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_filter_detail");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FilterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("filter_id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.FilterType)
                    .HasColumnType("int(11)")
                    .HasColumnName("filter_type");
            });
            modelBuilder.Entity<OmakaseHideSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId).HasName("PRIMARY");
                entity.ToTable("omakase_hide_skill");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
            });
            modelBuilder.Entity<OmakaseModify>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("omakase_modify");
                entity.Property(e => e.ModifyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("modify_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });
            modelBuilder.Entity<OmakaseModifyLegend>(entity =>
            {
                entity.HasKey(e => e.BuffId).HasName("PRIMARY");
                entity.ToTable("omakase_modify_legend");
                entity.Property(e => e.BuffId)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_id");
                entity.Property(e => e.BasePt)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_pt");
                entity.Property(e => e.ModifyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("modify_id");
                entity.Property(e => e.AddValue0)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value0");
                entity.Property(e => e.AddValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value1");
                entity.Property(e => e.AddValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value2");
            });
            modelBuilder.Entity<OmakaseModifyPt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_modify_pt");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.ModifyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("modify_id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.AddValue0)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value0");
                entity.Property(e => e.AddValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value1");
                entity.Property(e => e.AddValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value2");
            });
            modelBuilder.Entity<OmakaseOutingBasePt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_outing_base_pt");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.AddValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value");
            });
            modelBuilder.Entity<OmakaseScenario>(entity =>
            {
                entity.HasKey(e => e.ScenarioId).HasName("PRIMARY");
                entity.ToTable("omakase_scenario");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
            });
            modelBuilder.Entity<OmakaseState>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("omakase_state");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");
                entity.Property(e => e.SettingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("setting_id");
            });
            modelBuilder.Entity<OmakaseStopCondition>(entity =>
            {
                entity.HasKey(e => e.StopConditionId).HasName("PRIMARY");
                entity.ToTable("omakase_stop_condition");
                entity.Property(e => e.StopConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stop_condition_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.StopperType)
                    .HasColumnType("int(11)")
                    .HasColumnName("stopper_type");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });
            modelBuilder.Entity<OmakaseStopTrigger>(entity =>
            {
                entity.HasKey(e => e.StopTriggerId).HasName("PRIMARY");
                entity.ToTable("omakase_stop_trigger");
                entity.Property(e => e.StopTriggerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stop_trigger_id");
                entity.Property(e => e.TriggerType)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger_type");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });
            modelBuilder.Entity<OmakaseStopperEvent>(entity =>
            {
                entity.HasKey(e => e.StopperId).HasName("PRIMARY");
                entity.ToTable("omakase_stopper_event");
                entity.Property(e => e.StopperId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stopper_id");
                entity.Property(e => e.IsModifiable)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_modifiable");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.StopType)
                    .HasColumnType("int(11)")
                    .HasColumnName("stop_type");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });
            modelBuilder.Entity<RaceSpRuleData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("race_sp_rule_data");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceSpRuleType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_sp_rule_type");
            });
            modelBuilder.Entity<RaceSpRuleSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("race_sp_rule_schedule");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceSpRuleDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_sp_rule_data_id");
                entity.Property(e => e.EventCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_category");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.EventMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_month");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
            });
            modelBuilder.Entity<RaceSpRuleSkillset>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("race_sp_rule_skillset");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceSpRuleDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_sp_rule_data_id");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
            });
            modelBuilder.Entity<RentalDeck>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("rental_deck");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DistanceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance_type");
                entity.Property(e => e.GroundType)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground_type");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.DeckNameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("deck_name_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
            });
            modelBuilder.Entity<RentalDeckAlt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("rental_deck_alt");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.SupportCardAltId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_alt_id");
            });
            modelBuilder.Entity<RentalDeckCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("rental_deck_card");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RentalDeckId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rental_deck_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.LimitBreakCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_break_count");
                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasColumnName("position");
            });
            modelBuilder.Entity<ShopBanner>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("shop_banner");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ShopBannerName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("shop_banner_name");
                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_id");
            });
            modelBuilder.Entity<SingleMode109047Reward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_9047_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MinTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_turn");
                entity.Property(e => e.MaxTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_turn");
                entity.Property(e => e.EndType)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_type");
                entity.Property(e => e.GainType)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_type");
                entity.Property(e => e.GainValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_value");
            });
            modelBuilder.Entity<SingleMode109048Bonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_9048_bonus");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MinLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_level");
                entity.Property(e => e.MaxLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_level");
                entity.Property(e => e.LevelBonus)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_bonus");
            });
            modelBuilder.Entity<SingleMode109048Guest>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_9048_guest");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MinLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_level");
                entity.Property(e => e.MaxLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_level");
                entity.Property(e => e.LevelBonus1)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_bonus_1");
                entity.Property(e => e.LevelBonus2)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_bonus_2");
            });
            modelBuilder.Entity<SingleMode10AudienceEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_audience_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MinTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_turn");
                entity.Property(e => e.MaxTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_turn");
                entity.Property(e => e.AudienceEffect)
                    .HasColumnType("int(11)")
                    .HasColumnName("audience_effect");
            });
            modelBuilder.Entity<SingleMode10Buff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_buff");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BuffId)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_id");
                entity.Property(e => e.LegendId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_id");
                entity.Property(e => e.BuffRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_rank");
                entity.Property(e => e.BuffTrigger)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_trigger");
                entity.Property(e => e.ConditionGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_group_id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.BuffTurnType)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_turn_type");
                entity.Property(e => e.BuffTurnValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_turn_value");
                entity.Property(e => e.BuffCt)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_ct");
                entity.Property(e => e.Icon)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon");
                entity.Property(e => e.IsEnableInactivation)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_enable_inactivation");
            });
            modelBuilder.Entity<SingleMode10BuffCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_buff_condition");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_group_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_4");
            });
            modelBuilder.Entity<SingleMode10BuffEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_buff_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.LegendId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_id");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
            });
            modelBuilder.Entity<SingleMode10BuffNum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_buff_num");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.LegendId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_id");
                entity.Property(e => e.GaugeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_min");
                entity.Property(e => e.GaugeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_max");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.HighestNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("highest_num");
                entity.Property(e => e.LinkNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("link_num");
            });
            modelBuilder.Entity<SingleMode10CmDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_cm_detail");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.VoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_id");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.TargetValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value");
            });
            modelBuilder.Entity<SingleMode10GroupOutingEff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_group_outing_eff");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Step)
                    .HasColumnType("int(11)")
                    .HasColumnName("step");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
            });
            modelBuilder.Entity<SingleMode10LotteryTurn>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_lottery_turn");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });
            modelBuilder.Entity<SingleMode10Masterly>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_masterly");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.LegendId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_id");
                entity.Property(e => e.BuffNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("buff_num");
                entity.Property(e => e.ConditionGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_group_id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
            });
            modelBuilder.Entity<SingleMode10Sprace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_sprace");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_group_id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });
            modelBuilder.Entity<SingleMode10StagingSound>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_10_staging_sound");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StagingType)
                    .HasColumnType("int(11)")
                    .HasColumnName("staging_type");
                entity.Property(e => e.CutNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_number");
                entity.Property(e => e.MotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_type");
                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name");
                entity.Property(e => e.SeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cuesheet_name");
            });
            modelBuilder.Entity<SingleMode11CheckPointEff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_check_point_eff");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.ResultState)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_state");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode11FacilityEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_facility_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_id");
                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode11FacilityKind>(entity =>
            {
                entity.HasKey(e => e.FacilityId).HasName("PRIMARY");
                entity.ToTable("single_mode_11_facility_kind");
                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
            });
            modelBuilder.Entity<SingleMode11FacilityLvUp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_facility_lv_up");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_id");
                entity.Property(e => e.CurrentStateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("current_state_id");
                entity.Property(e => e.TargetStateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_state_id");
                entity.Property(e => e.Cost)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost");
            });
            modelBuilder.Entity<SingleMode11FacilityState>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_facility_state");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_id");
                entity.Property(e => e.FacilityLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_lv");
                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id");
                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_id");
            });
            modelBuilder.Entity<SingleMode11GainTrainingPt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_gain_training_pt");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DeckId)
                    .HasColumnType("int(11)")
                    .HasColumnName("deck_id");
                entity.Property(e => e.TurnMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_min");
                entity.Property(e => e.TurnMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_max");
                entity.Property(e => e.GainShimaTrainingPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_shima_training_pt");
            });
            modelBuilder.Entity<SingleMode11OutingEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_outing_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.MinLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_lv");
                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasColumnName("value");
            });
            modelBuilder.Entity<SingleMode11PioneerPtBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_pioneer_pt_bonus");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.PtRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("pt_rate");
                entity.Property(e => e.AddValueMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value_max");
            });
            modelBuilder.Entity<SingleMode11Planning>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_planning");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DeckId)
                    .HasColumnType("int(11)")
                    .HasColumnName("deck_id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.PlanningTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("planning_turn");
                entity.Property(e => e.CheckPointTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_turn");
                entity.Property(e => e.TargetPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_pt");
            });
            modelBuilder.Entity<SingleMode11ShimaEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_shima_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.ResultState)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_state");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.RequiredFacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("required_facility_id");
            });
            modelBuilder.Entity<SingleMode11TrainingMini>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_11_training_mini");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MinLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_lv");
                entity.Property(e => e.MaxLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_lv");
                entity.Property(e => e.MemberNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("member_num");
            });
            modelBuilder.Entity<SingleMode12AssistantEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_assistant_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandType)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_type");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
            });
            modelBuilder.Entity<SingleMode12CheckDugResult>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_check_dug_result");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("schedule_id");
                entity.Property(e => e.RyokanRankMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("ryokan_rank_min");
                entity.Property(e => e.RyokanRankMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("ryokan_rank_max");
                entity.Property(e => e.ResultType)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_type");
            });
            modelBuilder.Entity<SingleMode12DigBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_dig_bonus");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StratumId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_id");
                entity.Property(e => e.DugValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("dug_value");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode12DigItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_dig_item");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_level");
                entity.Property(e => e.StratumType)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_type");
                entity.Property(e => e.DigValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("dig_value");
            });
            modelBuilder.Entity<SingleMode12DigPower>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_dig_power");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StratumType)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_type");
                entity.Property(e => e.ParamType)
                    .HasColumnType("int(11)")
                    .HasColumnName("param_type");
                entity.Property(e => e.ParamRankMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("param_rank_min");
                entity.Property(e => e.ParamRankMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("param_rank_max");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
            });
            modelBuilder.Entity<SingleMode12DigPowerRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_dig_power_rank");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DigPowerRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("dig_power_rank");
                entity.Property(e => e.DigPowerMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("dig_power_min");
                entity.Property(e => e.DigPowerMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("dig_power_max");
            });
            modelBuilder.Entity<SingleMode12EffectCategory>(entity =>
            {
                entity.HasKey(e => e.EffectId).HasName("PRIMARY");
                entity.ToTable("single_mode_12_effect_category");
                entity.Property(e => e.EffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id");
                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");
            });
            modelBuilder.Entity<SingleMode12FactorBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_factor_bonus");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FactorGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_group_id");
                entity.Property(e => e.StratumType)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_type");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
            });
            modelBuilder.Entity<SingleMode12Onsen>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_onsen");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.OpenTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("open_turn");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
            });
            modelBuilder.Entity<SingleMode12OnsenEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_onsen_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode12OutingEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_outing_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.StoryStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_step");
                entity.Property(e => e.TicketNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_num");
            });
            modelBuilder.Entity<SingleMode12RyokanRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_ryokan_rank");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.DugOnsenNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("dug_onsen_num");
                entity.Property(e => e.DugOnsenId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dug_onsen_id");
            });
            modelBuilder.Entity<SingleMode12Schedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_schedule");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });
            modelBuilder.Entity<SingleMode12SpaTicket>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_spa_ticket");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.TicketNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_num");
            });
            modelBuilder.Entity<SingleMode12Stratum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_12_stratum");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.OnsenId)
                    .HasColumnType("int(11)")
                    .HasColumnName("onsen_id");
                entity.Property(e => e.StratumOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_order");
                entity.Property(e => e.StratumType)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_type");
                entity.Property(e => e.StratumVolume)
                    .HasColumnType("int(11)")
                    .HasColumnName("stratum_volume");
            });
            modelBuilder.Entity<SingleMode13AddDreamPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_add_dream_point");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DeckId)
                    .HasColumnType("int(11)")
                    .HasColumnName("deck_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasColumnName("value");
            });
            modelBuilder.Entity<SingleMode13BcProgramFlag>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_bc_program_flag");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bc_group_id");
                entity.Property(e => e.ProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("program_id");
                entity.Property(e => e.DetermineRaceFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("determine_race_flag");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
            });
            modelBuilder.Entity<SingleMode13Member>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_member");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.BcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bc_group_id");
                entity.Property(e => e.BcNpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bc_npc_id");
            });
            modelBuilder.Entity<SingleMode13Rank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_rank");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RankId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_id");
                entity.Property(e => e.RankExp)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_exp");
                entity.Property(e => e.RankBonusEffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_bonus_effect_group_id");
            });
            modelBuilder.Entity<SingleMode13RankBonusEffectGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_rank_bonus_effect_group");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
            });
            modelBuilder.Entity<SingleMode13Schedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_schedule");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MeetingTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("meeting_turn");
                entity.Property(e => e.StartTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_turn");
                entity.Property(e => e.EndTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_turn");
                entity.Property(e => e.NeedTeamRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_team_rank");
                entity.Property(e => e.TeamSpLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_sp_lv");
            });
            modelBuilder.Entity<SingleMode13TeamRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_team_rank");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RankGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_group");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
            });
            modelBuilder.Entity<SingleMode13TeamSpEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_team_sp_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupType)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_type");
                entity.Property(e => e.EffectGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.NumSupportType)
                    .HasColumnType("int(11)")
                    .HasColumnName("num_support_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
            });
            modelBuilder.Entity<SingleMode13TeamSpLevel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_team_sp_level");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupType)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_type");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.NeedPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_point");
                entity.Property(e => e.EffectGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group");
            });
            modelBuilder.Entity<SingleMode13TopBgChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_13_top_bg_chara");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.RequiredTeamProgress)
                    .HasColumnType("int(11)")
                    .HasColumnName("required_team_progress");
                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .HasColumnName("member_id");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
            });
            modelBuilder.Entity<SingleMode14BasicEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_basic_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_3");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
            });
            modelBuilder.Entity<SingleMode14CheckPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_check_point");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
                entity.Property(e => e.SuccessPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_pt");
                entity.Property(e => e.GreatSuccessPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_success_pt");
            });
            modelBuilder.Entity<SingleMode14CheckPointEffect>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("single_mode_14_check_point_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.ResultState)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_state");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_3");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
            });
            modelBuilder.Entity<SingleMode14CheckPointPt>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("single_mode_14_check_point_pt");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.GainPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_pt");
            });
            modelBuilder.Entity<SingleMode14CheckPointPtEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_check_point_pt_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PtMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("pt_min");
                entity.Property(e => e.PtMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("pt_max");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_3");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
            });
            modelBuilder.Entity<SingleMode14DeckInfo>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("single_mode_14_deck_info");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DeckType)
                    .HasColumnType("int(11)")
                    .HasColumnName("deck_type");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });
            modelBuilder.Entity<SingleMode14FeelingBonus>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("single_mode_14_feeling_bonus");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FeelingNumMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("feeling_num_min");
                entity.Property(e => e.FeelingNumMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("feeling_num_max");
                entity.Property(e => e.AddValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value");
            });
            modelBuilder.Entity<SingleMode14FinalsEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_finals_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TextGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_group_id");
                entity.Property(e => e.SelectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_type");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_3");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
            });
            modelBuilder.Entity<SingleMode14FinalsGainSkill>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_finals_gain_skill");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SelectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_type");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
                entity.Property(e => e.SkillLevelNormal)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level_normal");
                entity.Property(e => e.SkillLevelSuccess)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level_success");
                entity.Property(e => e.SkillLevelGreatSuccess)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level_great_success");
            });
            modelBuilder.Entity<SingleMode14OutingEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_outing_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.StoryStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_step");
                entity.Property(e => e.SpecialFeelingNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_feeling_num");
            });
            modelBuilder.Entity<SingleMode14RegionEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_region_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("region_id");
                entity.Property(e => e.TextGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_3");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
            });
            modelBuilder.Entity<SingleMode14RegionEffectBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_region_effect_bonus");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("region_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.MinPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_pt");
                entity.Property(e => e.MaxPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_pt");
                entity.Property(e => e.AddValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value");
            });
            modelBuilder.Entity<SingleMode14RegionFeeling>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_region_feeling");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("region_id");
                entity.Property(e => e.RegionSelectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("region_select_type");
                entity.Property(e => e.FeelingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("feeling_id");
                entity.Property(e => e.FeelingNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("feeling_num");
            });
            modelBuilder.Entity<SingleMode14RegionSelect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_region_select");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RegionSelectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("region_select_type");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });
            modelBuilder.Entity<SingleMode14SpecialGainTurn>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_special_gain_turn");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");
            });
            modelBuilder.Entity<SingleMode14TwinkleRamen>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_14_twinkle_ramen");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TextGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_group");
                entity.Property(e => e.TextNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_number");
                entity.Property(e => e.CheckPointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_type");
                entity.Property(e => e.ResultState)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_state");
                entity.Property(e => e.TextType)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_type");
                entity.Property(e => e.TextTypeValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_type_value");
            });
            modelBuilder.Entity<SingleMode15ActEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_act_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode15ActInfo>(entity =>
            {
                entity.HasKey(e => e.ActType).HasName("PRIMARY");
                entity.ToTable("single_mode_15_act_info");
                entity.Property(e => e.ActType)
                    .HasColumnType("int(11)")
                    .HasColumnName("act_type");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
            });
            modelBuilder.Entity<SingleMode15ActMember>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_act_member");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ActType)
                    .HasColumnType("int(11)")
                    .HasColumnName("act_type");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
            });
            modelBuilder.Entity<SingleMode15Advice>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_advice");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FusionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("fusion_type");
                entity.Property(e => e.AddScheduleType)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_schedule_type");
            });
            modelBuilder.Entity<SingleMode15AdviceEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_advice_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AdviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("advice_id");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode15AdviceRecommend>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_advice_recommend");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });
            modelBuilder.Entity<SingleMode15CheckPointEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_check_point_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("schedule_id");
                entity.Property(e => e.ResultState)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_state");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode15FinalsActEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_finals_act_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode15FusionEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_fusion_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AdviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("advice_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });
            modelBuilder.Entity<SingleMode15OutingEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_outing_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.StoryStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_step");
                entity.Property(e => e.AddLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_level");
            });
            modelBuilder.Entity<SingleMode15Schedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_15_schedule");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
                entity.Property(e => e.NeedActNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_act_num");
                entity.Property(e => e.NeedActLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_act_level");
            });
            modelBuilder.Entity<SingleModeAudienceOverwrite>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_audience_overwrite");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.RaceGrade)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_grade");
                entity.Property(e => e.AudienceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("audience_type");
                entity.Property(e => e.CrowdSoundType)
                    .HasColumnType("int(11)")
                    .HasColumnName("crowd_sound_type");
                entity.Property(e => e.LiveType)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_type");
                entity.Property(e => e.StartTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_turn");
                entity.Property(e => e.EndTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_turn");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
            });
            modelBuilder.Entity<SingleModeEventChoiceReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_event_choice_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_type");
                entity.Property(e => e.EffectValueType0)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_type_0");
                entity.Property(e => e.EffectValueType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_type_1");
                entity.Property(e => e.EffectValueType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_type_2");
            });
            modelBuilder.Entity<SingleModeEventCrPriority>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_event_cr_priority");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DisplayId)
                    .HasColumnType("int(11)")
                    .HasColumnName("display_id");
                entity.Property(e => e.EffectValueCondition0)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_condition_0");
                entity.Property(e => e.EffectValueCondition1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_condition_1");
                entity.Property(e => e.EffectValueCondition2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_condition_2");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
            });
            modelBuilder.Entity<SingleModeHideStoryControl>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_hide_story_control");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });
            modelBuilder.Entity<SingleModeRaceUniqueCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_race_unique_condition");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Year)
                    .HasColumnType("int(11)")
                    .HasColumnName("year");
                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_program_id");
                entity.Property(e => e.RaceConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_condition_id");
                entity.Property(e => e.FrameOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("frame_order");
                entity.Property(e => e.FinishOrder0)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_0");
            });
            modelBuilder.Entity<SingleModeSelectSkip>(entity =>
            {
                entity.HasKey(e => e.StoryId).HasName("PRIMARY");
                entity.ToTable("single_mode_select_skip");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
                entity.Property(e => e.AutoSelectedIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("auto_selected_index");
            });
            modelBuilder.Entity<SingleModeStoryConditionSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_story_condition_set");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionStoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_story_id_1");
                entity.Property(e => e.GainSelect1)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_select_1");
                entity.Property(e => e.SelectIndex1)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_index_1");
                entity.Property(e => e.ConditionStoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_story_id_2");
                entity.Property(e => e.GainSelect2)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_select_2");
                entity.Property(e => e.SelectIndex2)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_index_2");
                entity.Property(e => e.ConditionStoryId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_story_id_3");
                entity.Property(e => e.GainSelect3)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_select_3");
                entity.Property(e => e.SelectIndex3)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_index_3");
            });
            modelBuilder.Entity<SingleModeStoryRoot>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("single_mode_story_root");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
                entity.Property(e => e.SuggestSelect)
                    .HasColumnType("int(11)")
                    .HasColumnName("suggest_select");
                entity.Property(e => e.SuggestIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("suggest_index");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionStoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_story_id_1");
                entity.Property(e => e.GainSelect1)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_select_1");
                entity.Property(e => e.SelectIndex1)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_index_1");
                entity.Property(e => e.ConditionStoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_story_id_2");
                entity.Property(e => e.GainSelect2)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_select_2");
                entity.Property(e => e.SelectIndex2)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_index_2");
                entity.Property(e => e.ConditionStoryId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_story_id_3");
                entity.Property(e => e.GainSelect3)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_select_3");
                entity.Property(e => e.SelectIndex3)
                    .HasColumnType("int(11)")
                    .HasColumnName("select_index_3");
            });
            modelBuilder.Entity<SkillUpgradeSuccessionSkill>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("skill_upgrade_succession_skill");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");
                entity.Property(e => e.BaseSkillId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("base_skill_id");
                entity.Property(e => e.SkillId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });
            modelBuilder.Entity<SqliteStat1>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("sqlite_stat1");
                entity.Property(e => e.Tbl)
                    .HasColumnType("text")
                    .HasColumnName("tbl");
                entity.Property(e => e.Idx)
                    .HasColumnType("text")
                    .HasColumnName("idx");
                entity.Property(e => e.Stat)
                    .HasColumnType("text")
                    .HasColumnName("stat");
            });
            modelBuilder.Entity<StoryCharaUniqueDiffType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("story_chara_unique_diff_type");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DifferenceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difference_type");
            });
            modelBuilder.Entity<StoryExtraEventMovie>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("story_extra_event_movie");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.StoryDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_data_id");
            });
            modelBuilder.Entity<StoryRaceTrackBgReplace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("story_race_track_bg_replace");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
                entity.Property(e => e.BgGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_group_id");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_track_id");
                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_sub_id");
            });
            modelBuilder.Entity<SubscriptionTotalReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("subscription_total_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.TotalMonth)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_month");
                entity.Property(e => e.RewardItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_id");
                entity.Property(e => e.RewardItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_category");
                entity.Property(e => e.RewardItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_num");
            });
            modelBuilder.Entity<SuccessionFactorAddonEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("succession_factor_addon_effect");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_4");
                entity.Property(e => e.ConditionValue5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_5");
                entity.Property(e => e.ConditionValue6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_6");
                entity.Property(e => e.FactorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("factor_id");
            });
            modelBuilder.Entity<SystemVoiceStandbyMotion>(entity =>
            {
                entity.HasKey(e => e.CharaId).HasName("PRIMARY");
                entity.ToTable("system_voice_standby_motion");
                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.StandbyMotionId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_id_1");
                entity.Property(e => e.StandbyMotionId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_id_2");
            });
            modelBuilder.Entity<TrainerSkill>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("trainer_skill");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.NeedItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_item_num");
                entity.Property(e => e.ActiveTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("active_time");
                entity.Property(e => e.EnableSingleMode)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enable_single_mode");
                entity.Property(e => e.EnableIdleSingleMode)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enable_idle_single_mode");
                entity.Property(e => e.EnableGenerateSuccession)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enable_generate_succession");
                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");
                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });
            modelBuilder.Entity<TrainingChallengeRankingBorder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("training_challenge_ranking_border");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.TrainingChallengeMasterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("training_challenge_master_id");
                entity.Property(e => e.RankStart)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank_start");
                entity.Property(e => e.RankEnd)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank_end");
            });
            modelBuilder.Entity<TrainingChallengeRankingReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("training_challenge_ranking_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.TrainingChallengeRankingBorderId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("training_challenge_ranking_border_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");
            });
            modelBuilder.Entity<TrainingReportLoopReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("training_report_loop_reward");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.RewardSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set");
                entity.Property(e => e.IsPickup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_pickup");
                entity.Property(e => e.RewardItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_id");
                entity.Property(e => e.RewardItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_category");
                entity.Property(e => e.RewardItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_num");
                entity.Property(e => e.PerPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("per_point");
                entity.Property(e => e.LoopNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("loop_num");
            });
            modelBuilder.Entity<UltimateRaceUnlockCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("ultimate_race_unlock_condition");
                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");
                entity.Property(e => e.EventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_id");
                entity.Property(e => e.ConditionRaceContentsId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_race_contents_id_1");
                entity.Property(e => e.ConditionRaceContentsId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_race_contents_id_2");
                entity.Property(e => e.ConditionRaceContentsId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_race_contents_id_3");
                entity.Property(e => e.ConditionRaceContentsId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_race_contents_id_4");
                entity.Property(e => e.ConditionRaceContentsId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_race_contents_id_5");
                entity.Property(e => e.CuttId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_id");
                entity.Property(e => e.CuttCharaId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_chara_id_1");
                entity.Property(e => e.CuttDressId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_dress_id_1");
                entity.Property(e => e.CuttCharaId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_chara_id_2");
                entity.Property(e => e.CuttDressId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_dress_id_2");
                entity.Property(e => e.CuttCharaId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_chara_id_3");
                entity.Property(e => e.CuttDressId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_dress_id_3");
                entity.Property(e => e.TxtPositionX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("txt_position_x");
                entity.Property(e => e.TxtPositionY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("txt_position_y");
            });
        }
    }
}
