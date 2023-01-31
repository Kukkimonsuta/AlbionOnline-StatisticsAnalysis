namespace StatisticsAnalysisTool.Enumerations;

public enum EventCodes
{
    Unused = 0,
    Leave,
    JoinFinished, // <- UserInfo,
    Move,
    Teleport,
    ChangeEquipment,
    HealthUpdate = 6,
    EnergyUpdate,
    DamageShieldUpdate,
    CraftingFocusUpdate,
    ActiveSpellEffectsUpdate = 10,
    ResetCooldowns,
    Attack,
    CastStart,
    ChannelingUpdate,
    CastCancel,
    CastTimeUpdate,
    CastFinished,
    CastSpell,
    CastHit,
    CastHits,
    ChannelingEnded,
    AttackBuilding,
    InventoryPutItem = 25, //  map[0:652 1:6 2:[118 -97 114 112 -46 84 -60 75 -103 -93 -3 -29 118 -125 -50 96] 3:17 252:23] (0: ObjectId, 1: Inventory slot (no value is slot 0), 2: InteractGuid)
    InventoryDeleteItem = 26, // map[0:754 1:48 252:24] (0: ObjectId) 
    NewCharacter = 27,
    NewEquipmentItem = 28, //  map[0:657 1:2036 2:1 4:28169331 5:Apolo540 6:3 7:90000000 8:[] 9:[0] 252:27] (0: ObjectId, 1: ItemId, 2: Amount, 4: Est. market value, 5: CrafterName)
    NewSimpleItem = 29, //  map[0:505 1:7006 2:1 3:true 4:29033970 252:27] (0: ObjectId, 1: ItemId, 2: Amount, 4: Est. market value)
    NewFurnitureItem = 30,
    NewJournalItem = 31,
    NewLaborerItem = 32, // [0:513 1:7996 2:4 4:522947156 5: 6:10000 7:72000000 252:32]
    NewSimpleHarvestableObject,
    NewSimpleHarvestableObjectList,
    NewHarvestableObject = 35, // map[0:[3405 3468] 1:[6 6] 2:[3 2] 3:[182 -383 176 -369 183 -371] 4:[3 3] 252:35] - 0: ObjectId 2: Max Aufladungen, 4: Aktuelle Aufladungen
    NewSilverObject,
    NewBuilding,
    HarvestableChangeState,
    MobChangeState,
    FactionBuildingInfo,
    CraftBuildingInfo,
    RepairBuildingInfo,
    MeldBuildingInfo,
    ConstructionSiteInfo,
    PlayerBuildingInfo,
    FarmBuildingInfo,
    TutorialBuildingInfo,
    LaborerObjectInfo,
    LaborerObjectJobInfo,
    MarketPlaceBuildingInfo,
    HarvestStart = 54, // map[0:5270 1:637926215956544319 2:637926215956544319 3:4250 4:16 5:1.6169999 6:5287 7:2195 252:52] - 0 = UserId, 3 = ObjectId, 7 = Abbau-Tool (T8_2H_TOOL_SICKLE), 
    HarvestCancel,
    HarvestFinished = 57, // map[0:5270 1:637926215956544319 2:637926215972723131 3:4250 4:1 5:1 7:28 8:[] 9:[] 252:54] - 0: UserId, 3: ObjectId, 4:ItemId 5: Res Standard Quantity 6: Sammelbonus Res, 6: Premium Bonus Res, 8: Inhalt in der Ressource
    TakeSilver = 58, // map[0:-57 1:2178162 2:-57 3:10000000 8:10000 252:55]
    ActionOnBuildingStart,
    ActionOnBuildingCancel,
    ActionOnBuildingFinished = 61, // Repear: [60]evInstallResourceCancel - map[0:1562 1:63802829 282167 2:442 3:454 4:2 252:60] 0: UserObjectId, 2: ActionId, 4: ActionType
    ItemRerollQualityStart,
    ItemRerollQualityCancel,
    ItemRerollQualityFinished,
    InstallResourceStart,
    InstallResourceCancel,
    InstallResourceFinished,
    CraftItemFinished,
    LogoutCancel,
    ChatMessage,
    ChatSay,
    ChatWhisper,
    ChatMuted,
    PlayEmote,
    StopEmote,
    SystemMessage,
    UtilityTextMessage,
    UpdateSilver = 76, // map[0:4195 1:884995625105 252:71] (0: ObjectId, 1: CurrentSilver)
    UpdateFame = 77, // map[0:4195 1:5811910006347 2:100000000 4:10000 6:1 7:427 252:72] (0: ObjectId, 1: TotalPlayerFame, 2: fameWithZoneMultiplier, 3: GroupSize, 4: Multiplier, 5: IsPremiumBonus, 6: BonusFactor, 8: UsedBagInsightItemIndex, 10: SatchelFame, )
    UpdateLearningPoints,
    UpdateReSpecPoints = 79, // map[0:[0 55814284204 0 0 0] 1:1 2:9948534 3:10000000 252:78] 2: GainedReSpec, 3: PaidSilver
    UpdateCurrency = 80,
    UpdateFactionStanding = 81,
    UpdateBrecilienStanding, // map[0:11575080 1:3858360 2:970279167 252:81] 0: StandingPoints
    Respawn,
    ServerDebugLog,
    CharacterEquipmentChanged = 85,
    RegenerationHealthChanged,
    RegenerationEnergyChanged,
    RegenerationMountHealthChanged,
    RegenerationCraftingChanged,
    RegenerationHealthEnergyComboChanged,
    RegenerationPlayerComboChanged,
    DurabilityChanged,
    NewLoot = 93, // map[0:1863 2:1853 3:Dicky 4:[236.79169 -185.40233] 5:42.864536 6:true 7:1 10:[[-85 -58 82 55 101 -15 76 79 -103 -113 -21 8 -33 46 -99 -28]] 
    // 12:637993823308929158 18:[] 19:[-63 68 12 104 -29 1 114 78 -91 -75 -21 68 -13 -96 -29 -67] 20:[-23 20 93 -6 73 127 19 78 -65 44 -42 65 -97 105 -82 -16] 21:25900 22:0 23:3 24:-1 252:89]
    AttachItemContainer = 94, //  map[0:78 1:[-99 -50 125 -49 86 0 -115 74 -74 67 9 101 -87 -71 -66 -10] 3:[0 0 0 0 0 0 656 657] 4:8 252:89] (0: ObjectId, 3: ItemId[])
    DetachItemContainer, //  map[0:[-95 72 -77 -75 -70 34 127 73 -114 -96 28 8 75 -107 -106 125] 252:90]
    InvalidateItemContainer,
    LockItemContainer,
    GuildUpdate,
    GuildPlayerUpdated,
    InvitedToGuild,
    GuildMemberWorldUpdate,
    UpdateMatchDetails,
    ObjectEvent,
    NewMonolithObject,
    NewSiegeCampObject,
    NewOrbObject,
    NewCastleObject,
    NewSpellEffectArea,
    UpdateSpellEffectArea,
    NewChainSpell,
    UpdateChainSpell,
    NewTreasureChest,
    StartMatch,
    StartTerritoryMatchInfos,
    StartArenaMatchInfos,
    EndTerritoryMatch,
    EndArenaMatch,
    MatchUpdate,
    ActiveMatchUpdate,
    NewMob = 117,
    DebugAggroInfo,
    DebugVariablesInfo,
    DebugReputationInfo,
    DebugDiminishingReturnInfo,
    DebugSmartClusterQueueInfo,
    ClaimOrbStart,
    ClaimOrbFinished,
    ClaimOrbCancel,
    OrbUpdate,
    OrbClaimed,
    NewWarCampObject,
    NewMatchLootChestObject,
    NewArenaExit,
    GuildMemberTerritoryUpdate,
    InvitedMercenaryToMatch,
    ClusterInfoUpdate,
    ForcedMovement,
    ForcedMovementCancel,
    CharacterStats,
    CharacterStatsKillHistory,
    CharacterStatsDeathHistory,
    GuildStats,
    KillHistoryDetails,
    FullAchievementInfo,
    FinishedAchievement,
    AchievementProgressInfo,
    FullAchievementProgressInfo,
    FullTrackedAchievementInfo,
    FullAutoLearnAchievementInfo,
    QuestGiverQuestOffered,
    QuestGiverDebugInfo,
    ConsoleEvent,
    TimeSync,
    ChangeAvatar,
    ChangeMountSkin,
    GameEvent,
    KilledPlayer,
    Died = 155,
    KnockedDown,
    MatchPlayerJoinedEvent,
    MatchPlayerStatsEvent,
    MatchPlayerStatsCompleteEvent,
    MatchTimeLineEventEvent,
    MatchPlayerMainGearStatsEvent,
    MatchPlayerChangedAvatarEvent,
    InvitationPlayerTrade,
    PlayerTradeStart,
    PlayerTradeCancel,
    PlayerTradeUpdate,
    PlayerTradeFinished,
    PlayerTradeAcceptChange,
    MiniMapPing,
    MarketPlaceNotification,
    DuellingChallengePlayer,
    NewDuellingPost,
    DuelStarted,
    DuelEnded,
    DuelDenied,
    DuelLeftArea,
    DuelReEnteredArea,
    NewRealEstate,
    MiniMapOwnedBuildingsPositions,
    RealEstateListUpdate,
    GuildLogoUpdate,
    GuildLogoChanged,
    PlaceableObjectPlace,
    PlaceableObjectPlaceCancel,
    FurnitureObjectBuffProviderInfo,
    FurnitureObjectCheatProviderInfo,
    FarmableObjectInfo,
    NewUnreadMails,
    Unknown187,
    GuildLogoObjectUpdate,
    StartLogout,
    NewChatChannels,
    JoinedChatChannel,
    LeftChatChannel,
    RemovedChatChannel,
    AccessStatus,
    Mounted,
    MountStart,
    MountCancel,
    NewTravelpoint,
    NewIslandAccessPoint,
    NewExit,
    UpdateHome,
    UpdateChatSettings,
    ResurrectionOffer,
    ResurrectionReply,
    LootEquipmentChanged,
    UpdateUnlockedGuildLogos,
    UpdateUnlockedAvatars,
    UpdateUnlockedAvatarRings,
    UpdateUnlockedBuildings,
    NewIslandManagement,
    NewTeleportStone,
    Cloak,
    PartyInvitation,
    PartyJoined,
    PartyChangedOrder = 219, // map[0:14368 2:1 3:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 4:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] [-118 61 -70 72 17 -107 121 72 -102 110 20 -25 64 20 106 2]] 5:[Triky313 Bruno313] 6:[0 0] 7:[18 0] 8:[35 0] 9:[-1 -1] 10:[true true] 252:212]
    PartyDisbanded = 220, // map[1:14184 252:213]
    PartyPlayerJoined = 221, // map[0:11925 1:[-63 -19 39 16 26 35 -25 67 -111 60 -87 -58 -31 -100 -124 -44] 2:Mitch77 3:1 4:20 5:12 6:-1 7:true 252:214]
    PartyPlayerLeft = 223, // map[0:14368 1:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 252:216]
    PartyLeaderChanged = 224, // map[0:14595 1:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 252:217]
    PartyLootSettingChangedPlayer = 225, // map[0:14368 1:1 252:218]
    PartySilverGained,
    PartyPlayerUpdated = 228, // map[0:Bruno313 1:true 3:5 252:221]
    PartyInvitationPlayerBusy,
    PartyMarkedObjectsUpdated,
    PartyOnClusterPartyJoined,
    PartySetRoleFlag, // map[0:8 1:[-118 61 -70 72 17 -107 121 72 -102 110 20 -25 64 20 106 2] 252:225] (0: FlagType, 1: ObjectId)
    PartyJoinRequest = 233,
    SpellCooldownUpdate,
    NewHellgate,
    NewHellgateExit,
    NewExpeditionExit,
    NewExpeditionNarrator,
    ExitEnterStart,
    ExitEnterCancel,
    ExitEnterFinished,
    HellClusterTimeUpdate,
    NewQuestGiverObject,
    FullQuestInfo,
    QuestProgressInfo,
    QuestGiverInfoForPlayer,
    FullExpeditionInfo,
    ExpeditionQuestProgressInfo,
    InvitedToExpedition,
    ExpeditionRegistrationInfo,
    EnteringExpeditionStart,
    EnteringExpeditionCancel,
    RewardGranted,
    ArenaRegistrationInfo,
    EnteringArenaStart,
    EnteringArenaCancel,
    EnteringArenaLockStart,
    EnteringArenaLockCancel,
    InvitedToArenaMatch,
    PlayerCounts,
    OtherGrabbedLoot,
    InCombatStateUpdate = 262, // map[0:671362 1:true 2:true 252:257] | 1 = true; player hits enemy | 2 = true; enemy hits player
    GrabbedLoot = 263, // LOOT: map[0:424 1:Triky313 2:Bruno313 4:1841 5:1 252:256] | SILVER: map[0:6436 2:Triky313 3:true 5:1550115 252:256] (0: ObjectId, 1: LootedBody, 2: Looter, 4: ItemId, 5: Quantity) 
    SiegeCampClaimStart = 264,
    SiegeCampClaimCancel,
    SiegeCampClaimFinished,
    SiegeCampScheduleResult,
    TreasureChestUsingStart,
    TreasureChestUsingFinished,
    TreasureChestUsingCancel,
    TreasureChestUsingOpeningComplete,
    TreasureChestForceCloseInventory,
    PremiumChanged,
    PremiumExtended,
    PremiumLifeTimeRewardGained,
    LaborerGotUpgraded,
    JournalGotFull,
    JournalFillError,
    FriendRequest,
    FriendRequestInfos,
    FriendInfos,
    FriendRequestAnswered,
    FriendOnlineStatus,
    FriendRequestCanceled,
    FriendRemoved,
    FriendUpdated,
    PartyLootItems,
    PartyLootItemsRemoved,
    ReputationUpdate,
    DefenseUnitAttackBegin,
    DefenseUnitAttackEnd,
    DefenseUnitAttackDamage,
    UnrestrictedPvpZoneUpdate,
    ReputationImplicationUpdate,
    NewMountObject,
    MountHealthUpdate,
    MountCooldownUpdate,
    NewExpeditionAgent,
    NewExpeditionCheckPoint,
    ExpeditionStartent,
    Voteent,
    Ratingent,
    NewArenaAgent,
    BoostFarmable,
    UseFunction,
    NewPortalEntrance,
    NewPortalExit,
    NewRandomDungeonExit,
    WaitingQueueUpdate,
    PlayerMovementRateUpdate,
    ObserveStart,
    MinimapZergs,
    MinimapSmartClusterZergs,
    PaymentTransactions,
    PerformanceStatsUpdate,
    OverloadModeUpdate,
    DebugDrawEvent,
    RecordCameraMove,
    RecordStart,
    TerritoryClaimStart,
    TerritoryClaimCancel,
    TerritoryClaimFinished,
    TerritoryScheduleResult,
    UpdateAccountState,
    StartDeterministicRoam,
    GuildFullAccessTagsUpdated,
    GuildAccessTagUpdated,
    GvgSeasonUpdate,
    GvgSeasonCheatCommand,
    SeasonPointsByKillingBooster,
    FishingStart,
    FishingCast,
    FishingCatch,
    FishingFinished,
    FishingCancel,
    NewFloatObject,
    NewFishingZoneObject,
    FishingMiniGame,
    SteamAchievementCompleted,
    UpdatePuppet,
    ChangeFlaggingFinished,
    NewOutpostObject,
    OutpostUpdate,
    OutpostClaimed,
    OutpostReward,
    OverChargeEnd,
    OverChargeStatus,
    PartyFinderFullUpdate,
    PartyFinderUpdate,
    PartyFinderApplicantsUpdate,
    PartyFinderEquipmentSnapshot,
    PartyFinderJoinRequestDeclined,
    NewUnlockedPersonalSeasonRewards,
    PersonalSeasonPointsGained,
    ChallengePoints = 353, // map[0:1578596 252:352]
    EasyAntiCheatMessageToClient,
    MatchLootChestOpeningStart,
    MatchLootChestOpeningFinished,
    MatchLootChestOpeningCancel,
    NotifyCrystalMatchReward,
    CrystalRealmFeedback,
    NewLocationMarker,
    NewTutorialBlocker,
    NewTileSwitch,
    NewInformationProvider,
    NewDynamicGuildLogo,
    TutorialUpdate,
    TriggerHintBox,
    RandomDungeonPositionInfo,
    NewLootChest = 375, // map[0:23 1:[20.5 177.5] 2:423 3:KEEPER_SOLO_BOOKCHEST_STANDARD 4:FOREST_GREEN_LOOTCHEST_KEEPER_SOLO_BOOKCHEST_STANDARD 5:4 6:637734315213820408 7:[] 8:[] 13:true 252:367] // map[0:4399 1:[165 -263] 3:TREASURE_SOLO_UNCOMMON 4:SWAMP_DEAD_LOOTCHEST_TREASURE_SOLO_UNCOMMON 5:4 6:637926439332719127 7:[] 8:[] 13:true 14:SWAMP_DEAD_TREASURE_SOLO 16:31ff503a-ded6-53d6-974a-7e32e3126457 252:370]
    UpdateLootChest = 376, // 0=ObjectId, 3=PlayerGuid, 4=PlayerGuid, 7=Free4All map[0:4769 1:5 2:637927794424868192 3:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101]] 4:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101]] 6:true 7:true 8:2.6 9:true 252:371]
    LootChestOpened = 377, // map[0:23 252:369]
    EventCode378,
    NewShrine = 379, // map[0:19 1:[-89 90] 2:180 3:GENERAL_SHRINE_COMBAT_BUFF 4:SHRINE_NON_COMBAT_BUFF 5:1 6:637734312344532502 252:371]
    UpdateShrine = 380, // map[0:19 1:2 2:637734313445294913 252:372]
    MutePlayerUpdate,
    ShopTileUpdate,
    ShopUpdate,
    EasyAntiCheatKick,
    UnlockVanityUnlock,
    AvatarUnlocked,
    CustomizationChanged,
    GuildVaultInfo = 393,
    BaseVaultInfo = 394,
    BankVaultInfo, // map[0:6 1:6466931c-65a1-4c5d-870b-8724cf2611dc@3007 2:[] 3:[] 4:[] 5:[] 6:[] 7:[] 8:[] 252:390]
    RecoveryVaultPlayerInfo = 396,
    RecoveryVaultGuildInfo,
    UpdateWardrobe,
    CastlePhaseChanged,
    GuildAccountLogEvent,
    NewHideoutObject,
    NewHideoutManagement,
    NewHideoutExit,
    InitHideoutAttackStart,
    InitHideoutAttackCancel,
    InitHideoutAttackFinished,
    HideoutManagementUpdate,
    IpChanged,
    SmartClusterQueueUpdateInfo,
    SmartClusterQueueActiveInfo,
    SmartClusterQueueKickWarning,
    SmartClusterQueueInvite,
    ReceivedSeasonPoints = 400,
    TerritoryBonusLevelUpdate,
    OpenWorldAttackScheduleStart,
    OpenWorldAttackScheduleFinished,
    OpenWorldAttackScheduleCancel,
    OpenWorldAttackConquerStart,
    OpenWorldAttackConquerFinished,
    OpenWorldAttackConquerCancel,
    OpenWorldAttackConquerStatus,
    OpenWorldAttackStart,
    OpenWorldAttackEnd,
    NewRandomResourceBlocker,
    NewHomeObject,
    HideoutObjectUpdate,
    UpdateInfamy,
    Unknown408,
    Unknown409,
    Unknown410,
    Unknown411,
    Unknown412,
    Unknown413,
    Unknown414,
    Unknown415,
    Unknown416,
    Unknown417,
    Unknown418,
    Unknown419,
    Unknown420,
    Unknown421,
    Unknown422,
    MightFavorPoints = 475 // map[0:63063 2:21021 3:16617 5:5539 6:349680 8:0 252:470] (0: Might, 2: Premium of might, 3: Favor, 5: Premium of favor, 6: Total favor, 8: ???) 
}