﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHServerEmu
{
    public enum AuthMessage : byte
    {
        AuthRequiredDoc,
        AuthTicket,
        ConsoleCreateAccountMessageResponse,
        PrecacheHeadersMessageResponse,
        NewsMessageResponse,
        MHLocalizedNewsLayout,
        MHLocalizedNewsEntry
    }

    public enum BillingCommonMessage : byte
    {
        MHCatalogEntryType,
        MHCatalogEntryTypeModifier,
        MHBannerUrl,
        MHLocalizedCatalogUrls,
        MHLocalizedCatalogEntry,
        MHLocalizedCatalogEntryUrlOrData,
        MHCatalogGuidEntry,
        MarvelHeroesCatalogEntry,
        MHLocalizedStringCollection,
        MHStringValue,
        MHConsolePresentationEntry,
        MHConsoleItemPrice,
        MHConsoleDiscount,
        MHConsoleUpsell,
        MarvelHeroesConsoleCatalogEntry,
        MHConsoleCatalogCategoryEntry,
        MHConsoleCatalogTagEntry,
        MHConsoleCatalogFeaturedEntry,
        MHConsoleCatalogFeatureLayout,
        MHConsoleCatalogFeatured,
        GiftHistoryEntry,
        GiftHistoryForPlayerEntry,
        AwardItem,
        AwardCouponDescription,
        AwardCoupon,
        AwardEntry,
        MessageEntitlementStatus,
        BillingPlayStationUpdateEntitlementStatus,
        MessageEntitlementStatusResponse,
        BillingPlayStationUpdateEntitlementStatusResponse,
        BillingAcquireUnfulfilledOrders
    }

    public enum ChatCommonMessage : byte
    {
        ChatMessageAttachments,
        ChatMessage
    }

    public enum ClientToGameServerMessage : byte
    {
        NetMessageReadyForGameJoin,
        NetMessagePlayerSystemMetrics,
        NetMessagePlayerSteamInfo,
        NetMessageSyncTimeRequest,
        NetMessageSetTimeDialation,
        NetMessageIsRegionAvailable,
        NetMessageUpdateAvatarState,
        NetMessageCellLoaded,
        NetMessageTeleportAckResponse,
        NetMessageAdminCommand,
        NetMessageTryActivatePower,
        NetMessagePowerRelease,
        NetMessageTryCancelPower,
        NetMessageTryCancelActivePower,
        NetMessageContinuousPowerUpdateToServer,
        NetMessageCancelPendingAction,
        NetMessageStartAIDebugUI,
        NetMessageStopAIDebugUI,
        NetMessageStartAIPerformanceUI,
        NetMessageStopAIPerformanceUI,
        NetMessageStartMissionDebugUI,
        NetMessageStopMissionDebugUI,
        NetMessageStartPropertiesDebugUI,
        NetMessageStopPropertiesDebugUI,
        NetMessageStartConditionsDebugUI,
        NetMessageStopConditionsDebugUI,
        NetMessageStartPowersDebugUI,
        NetMessageStopPowersDebugUI,
        NetStructMessageStoreMetric,
        NetMessagePing,
        NetMessageFPS,
        NetMessageGamepadMetric,
        NetMessagePickupInteraction,
        NetMessageTryInventoryMove,
        NetMessageTryMoveCraftingResultsToGeneral,
        NetMessageInventoryTrashItem,
        NetMessageThrowInteraction,
        NetMessagePerformPreInteractPower,
        NetMessageUseInteractableObject,
        NetMessageTryCraft,
        NetMessageUseWaypoint,
        NetMessageDebugAcquireAndSwitchToAvatar,
        NetMessageSwitchAvatar,
        NetMessageChangeDifficulty,
        NetMessageSelectPublicEventTeam,
        NetMessageRefreshAbilityKeyMapping,
        NetMessageAbilitySlotToAbilityBar,
        NetMessageAbilityUnslotFromAbilityBar,
        NetMessageAbilitySwapInAbilityBar,
        NetMessageModCommitTemporary,
        NetMessageModReset,
        NetMessagePowerRecentlyUnlocked,
        NetMessageRequestDeathRelease,
        NetMessageRequestResurrectDecline,
        NetMessageRequestResurrectAvatar,
        NetMessageReturnToHub,
        NetMessageRequestStoryWarp,
        NetMessageRequestMissionRewards,
        NetMessageRequestRemoveAndKillControlledAgent,
        NetMessageDamageMeter,
        NetMessageDuelInvite,
        NetMessageDuelAccept,
        NetMessageDuelCancel,
        NetMessageMetaGameUpdateNotification,
        NetMessageChat,
        NetMessageTell,
        NetMessageReportPlayer,
        NetMessageChatBanVote,
        NetMessageGetCatalog,
        NetMessageGetCurrencyBalance,
        NetMessageBuyItemFromCatalog,
        NetMessageBuyGiftForOtherPlayer,
        NetMessagePurchaseUnlock,
        NetMessageGetGiftHistory,
        EntityPreviewerEnum,
        NetMessageEntityPreviewerNewTargets,
        NetMessageEntityPreviewerClearTargets,
        NetMessageEntityPreviewerSetTargetRef,
        NetMessageEntityPreviewerActivatePower,
        NetMessageEntityPreviewerAddTarget,
        NetMessageEntityPreviewerSetEntityState,
        NetMessageEntityPreviewerApplyConditions,
        NetMessageCreateNewPlayerWithSelectedStartingAvatar,
        NetMessageOnKioskStartButtonPressed,
        NetMessageNotifyFullscreenMovieStarted,
        NetMessageNotifyFullscreenMovieFinished,
        NetMessageNotifyLoadingScreenFinished,
        NetMessageBotSetLevel,
        NetMessageBotGodMode,
        NetMessageBotPickAvatar,
        NetMessageBotRegionChange,
        NetMessageBotWarpAreaNext,
        NetMessageBotLootGive,
        NetMessageBotSetPvPFaction,
        NetMessageBotPvPQueue,
        NetMessageGetTrackerReport,
        NetMessagePlayKismetSeqDone,
        NetMessageVerifyFailedForRepId,
        NetMessageGracefulDisconnect,
        NetMessageRequestStartNewGame,
        NetMessageSetDialogTarget,
        NetMessageDialogResult,
        NetMessageVendorRequestBuyItemFrom,
        NetMessageVendorRequestSellItemTo,
        NetMessageVendorRequestDonateItemTo,
        NetMessageVendorRequestRefresh,
        NetMessageTryModifyCommunityMemberCircle,
        NetMessagePullCommunityStatus,
        NetMessageGuildMessageToPlayerManager,
        NetMessageAkEvent,
        NetMessageSetTipSeen,
        NetMessageHUDTutorialDismissed,
        NetMessageTryMoveInventoryContentsToGeneral,
        NetMessageSetPlayerGameplayOptions,
        NetMessageTeleportToPartyMember,
        NetMessageRegionRequestQueueCommandClient,
        NetMessageSelectAvatarSynergies,
        NetMessageRequestLegendaryMissionReroll,
        NetMessageAttemptShareLegendaryMission,
        NetMessageAttemptShareLegendaryMissionResponse,
        NetMessageRequestPlayerOwnsItemStatus,
        NetMessageRequestInterestInInventory,
        NetMessageRequestLoadInventorySlots,
        NetMessageRequestInterestInAvatarEquipment,
        NetMessageRequestInterestInTeamUpEquipment,
        NetMessageTryTeamUpSelect,
        NetMessageRequestTeamUpDismiss,
        NetMessageTryTeamUpStyleSelect,
        NetMessageSelectInfinityGemBonus,
        NetMessageInfinityPointAllocationCommit,
        NetMessageRespecInfinity,
        NetMessageSelectOmegaBonus,
        NetMessageOmegaBonusAllocationCommit,
        NetMessageRespecOmegaBonus,
        NetMessageRespecPowerSpec,
        NetMessageNewItemGlintPlayed,
        NetMessageNewItemHighlightCleared,
        NetMessageNewSynergyCleared,
        NetMessageUnassignMappedPower,
        NetMessageAssignStolenPower,
        NetMessageVanityTitleSelect,
        NetMessageRequestGlobalEventUpdate,
        NetMessageHasPendingGift,
        NetMessagePlayerTradeStart,
        NetMessagePlayerTradeCancel,
        NetMessagePlayerTradeSetConfirmFlag,
        NetMessageRequestPetTechDonate,
        NetMessageSetActivePowerSpec,
        NetMessageChangeCameraSettings,
        NetMessageRequestSocketAffix,
        NetMessageUISystemLockState,
        NetMessageEnableTalentPower,
        NetMessageStashInventoryViewed,
        NetMessageStashCurrentlyOpen,
        NetMessageWidgetButtonResult,
        NetMessageStashTabInsert,
        NetMessageStashTabOptions,
        NetMessageLeaderboardRequest,
        NetMessageLeaderboardArchivedInstanceListRequest,
        NetMessageLeaderboardInitializeRequest,
        NetMessageCoopOpRequest,
        NetMessageCouponAwardPresented,
        NetMessagePartyOperationRequest,
        NetMessagePSNNotification,
        NetMessageSuggestPlayerToPartyLeader,
        NetMessageMissionTrackerFilterChange,
        NetMessageMissionTrackerFiltersUpdate,
        NetMessageAchievementMissionTrackerFilterChange,
        NetMessageBillingRoutedClientMessage,
        NetMessagePlayerLookupByNameClientRequest,
        NetMessageCostumeChange,
        NetMessageLookForParty
    }

    public enum ClientToGroupingManagerMessage : byte
    {
        GetPlayerInfoByName
    }

    public enum CommonMessage : byte
    {
        NetStructPoint3,
        NetStructIPoint3,
        NetStructPoint2,
        NetStructIPoint2,
        NetStructProperty,
        NetStructPropertyList,
        NetStructFormatStringArg,
        NetStructFormatString,
        NetStructDialogButton,
        NetStructDialog,
        NetStructRegionLocation,
        NetStructRegionTarget,
        NetStructTransferParams,
        NetStructRegionOrigin,
        NetStructPortalInstance,
        ChangeRegionRequestHeader,
        NetStructCreateRegionParams,
        NetStructModChangeObject,
        NetStructAffixSpec,
        NetStructItemSpec,
        CommunityMemberAvatarSlot,
        CommunityMemberBroadcast,
        CommunityNotify,
        NetStructLiveTuningSettingEnumValue,
        NetStructLiveTuningSettingProtoEnumValue,
        ChangeRegionFailed,
        NetStructChatChannelFilterState,
        NetStructChatTabState,
        NetStructGameplayOptions,
        ShareLegendaryMissionRequest,
        ShareLegendaryMissionResult,
        BillingP2PGiftResult,
        LeaderboardPlayerScoreQuery,
        LeaderboardGuildScoreQuery,
        LeaderboardMetaScoreQuery,
        LeaderboardDataQuery,
        LeaderboardMetadata,
        LeaderboardEntry,
        LeaderboardTableData,
        LeaderboardScoreData,
        LeaderboardReport,
        LeaderboardInstanceData,
        WorldViewEntry,
        PartyOperationPayload,
        PartyMemberInfo,
        PartyInfo,
        PSNNotification
    }

    public enum FrontendProtocolMessage : byte
    {
        LoginDataPB,
        ConsoleServiceEntitlement,
        LoginDataConsole,
        CreateAccountConsole,
        AcceptDocuments,
        SelectPlayerName,
        InitialClientHandshake,
        ClientCredentials,
        LoginQueueStatus,
        SessionEncryptionChanged,
        ExtendedLoginError,
        EncryptedTrafficHeader,
        PrecacheHeaders,
        NewsRequest
    }

    public enum GameServerToClientMessage : byte
    {
        NetMessageReadyAndLoggedIn,
        NetMessageReadyAndLoadedOnGameServer,
        NetMessageReadyForTimeSync,
        NetStructGameOptions,
        NetMessageLocalPlayer,
        NetMessageEntityCreate,
        NetMessageEntityDestroy,
        NetMessageEntityTracked,
        NetMessageEntitySelectorAction,
        NetMessageInventoryMove,
        NetMessageInventoryUnlock,
        NetMessagePermaBuffUnlock,
        NetMessageEntityKill,
        NetMessageFullscreenMovieSync,
        NetMessageQueueFullscreenMovie,
        NetMessageQueueLoadingScreen,
        NetMessageDequeueLoadingScreen,
        NetMessageRegionChange,
        NetMessageEntityPosition,
        NetMessageLocomotionStateUpdate,
        NetMessageLootRollFailed,
        NetMessageLootEntity,
        NetMessageLootRewardReport,
        NetMessageInterestPolicies,
        NetMessageUnableToChangeRegion,
        NetStructAreaConnection,
        NetMessageAddArea,
        NetMessageRemoveArea,
        NetStructReservedSpawn,
        NetMessageCellCreate,
        NetMessageCellDestroy,
        NetMessageEnvironmentUpdate,
        NetMessageDebugSpawnMapVisualization,
        NetMessageChangeAOIPolicies,
        NetMessageFullInWorldHierarchyUpdateEnd,
        NetMessageFullInWorldHierarchyUpdateBegin,
        NetMessageAdminCommandResponse,
        NetMessageActivatePowerFailed,
        NetMessageCancelPower,
        NetMessageContinuousPowerUpdateToClient,
        NetMessageActivatePower,
        NetMessagePreActivatePower,
        NetMessagePowerResult,
        NetMessagePowerBounce,
        NetMessageOnPreInteractPowerEnd,
        NetMessageRegionPrimitiveBox,
        NetMessageRegionPrimitiveTriangle,
        NetMessageRegionPrimitiveSphere,
        NetMessageRegionPrimitiveCircle,
        NetMessageRegionPrimitiveLine,
        NetMessageMarkFirstGameFrame,
        NetMessageBeginExitGame,
        NetMessageSystemMessage,
        NetMessageAIPerformanceUIUpdate,
        NetMessageAIDebugUIUpdate,
        NetMessagePropertiesDebugUIUpdate,
        NetMessageConditionsDebugUIUpdate,
        NetMessagePowersDebugUIUpdate,
        NetMessageMissionDebugUIUpdate,
        NetMessageDebugEntityPosition,
        NetMessageServerFrameProfile,
        NetMessagePingResponse,
        NetMessageEntityEnterGameWorld,
        NetMessageTeleportAckRequest,
        NetMessageServerVersion,
        NetStructAgentSpec,
        NetStructVendorXPSummary,
        NetStructCurrencySpec,
        NetStructItemSpecStack,
        NetStructLootResultSummary,
        NetStructVaporizedItem,
        NetMessageVaporizedLootResult,
        NetMessageSocketGem,
        NetMessageMissionUpdate,
        NetStructMissionInteractionTag,
        NetMessageMissionObjectiveUpdate,
        NetMessageMissionRewardsResponse,
        NetMessageCurrentAvatarChanged,
        NetMessageNewAvatarAcquired,
        NetMessageNewTeamUpAcquired,
        NetStructPrefetchCell,
        NetMessagePrefetchAssets,
        NetMessagePrefetchRegionsForDownload,
        NetMessageQueryIsRegionAvailable,
        NetMessageShowOverheadText,
        NetMessageShowXPAwardedText,
        NetMessageAIToggleState,
        NetMessageDamageToggleState,
        NetMessageMatchTeamRosterNotification,
        NetMessageMatchTeamSizeNotification,
        NetMessageChatFromGameSystem,
        NetMessageChatFromMetaGame,
        NetMessageBroadcastRareItem,
        NetMessageChatError,
        NetMessageCatalogItems,
        NetMessageConsoleCatalogItems,
        NetMessageConsoleCatalogAvailable,
        AwardCouponEntryDesc,
        AwardCouponEntry,
        AwardItemEntry,
        NetMessageGetCurrencyBalanceResponse,
        NetMessageBuyItemFromCatalogResponse,
        NetMessageBuyGiftForOtherPlayerResponse,
        NetMessageGrantGToPlayerNotification,
        NetMessagePurchaseUnlockResponse,
        NetMessageEntityPreviewerNewTarget,
        NetMessageRemoteMissionNotification,
        NetMessageMetaGameInfoNotification,
        NetMessageClearMetaGameInfoNotification,
        NetMessageUINotificationMessage,
        NetMessageShowPvPScoreboard,
        NetMessageStartPvPTimer,
        NetMessageStopPvPTimer,
        NetMessageSetDifficultyThresholds,
        NetMessageSetUITrackedEntityId,
        NetMessageSetTimerText,
        NetMessageSetModeText,
        NetMessageSetExtraText,
        NetMessageBannerMessage,
        NetMessageHUDTutorial,
        NetMessageWaypointNotification,
        NetMessageRegionAvatarSwapUpdate,
        NetMessageRegionRestrictedRosterUpdate,
        NetMessageTeamSelectDialog,
        NetMessageAIAggroNotification,
        NetMessageAITargetChangeNotification,
        NetMessageStoryNotification,
        NetMessageSyncTimeReply,
        NetMessageInitialTimeSync,
        NetMessageSelectStartingAvatarForNewPlayer,
        NetMessageShowKioskStartScreen,
        NetMessageInventoryFull,
        NetMessageUnloadPackagesStart,
        NetMessageUnloadPackagesEnd,
        NetMessageForceDisconnect,
        NetMessageLevelUp,
        NetStructInfinityPointGain,
        NetMessageInfinityPointGain,
        NetMessageOmegaPointGain,
        NetMessageVendorLevelUp,
        NetMessageVendorRefresh,
        NetMessageCraftingSuccess,
        NetMessageCraftingFailure,
        NetMessagePlayPowerVisuals,
        NetMessageWaypointUnlocked,
        NetMessageReplicationArchive,
        NetMessageSetProperty,
        NetMessageRemoveProperty,
        NetMessagePvPScoreScoreUpdateEntry,
        NetMessagePvPScorePlayerNewId,
        NetMessagePvPScorePlayerTeamChange,
        NetMessagePvPScorePlayerUpdate,
        NetMessageTransitionUpdate,
        NetMessageAvatarNameChange,
        NetMessageMissionInteractRepeat,
        NetMessageMissionInteractRelease,
        NetMessageAddCondition,
        NetMessageDeleteCondition,
        NetMessageEnableCondition,
        NetMessageChangeConditionPauseTime,
        NetMessageChangeConditionDuration,
        NetMessageAbilitySlotToAbilityBarFromServer,
        NetMessageAbilityUnslotFromAbilityBarFromServer,
        NetMessageAbilitySwapInAbilityBarFromServer,
        NetMessagePowerCollectionAssignPower,
        NetMessageAssignPowerCollection,
        NetMessagePowerCollectionUnassignPower,
        NetMessageUpdatePowerIndexProps,
        NetMessageOnWaypointUpdated,
        NetMessageInternalReportPlayerLoadError,
        MessageReportEntry,
        NetMessageMessageReport,
        NetMessageUpdateMiniMap,
        NetMessageMoveToAlternateLandingSpot,
        NetMessageConsoleMessage,
        NetMessageAvatarOnKilledInfoOverride,
        NetMessageOnResurrect,
        NetMessageOnResurrectRequest,
        NetMessageOnResurrectDecline,
        NetMessageReloadPackagesStart,
        NetMessagePlayStoryBanter,
        NetMessagePlayUISoundTheme,
        NetMessagePlayKismetSeq,
        NetMessageGracefulDisconnectAck,
        NetMessageLiveTuningUpdate,
        NetMessageUpdateSituationalTarget,
        NetMessageConfirmStartNewGame,
        NetMessageOneTimeSnapCamera,
        NetMessageModifyCommunityMemberFailure,
        NetMessageModifyCommunityMember,
        NetMessageReceiveCommunityNotify,
        NetMessageItemBindingChanged,
        NetMessageItemsHeldForRecovery,
        NetMessageItemRecovered,
        NetMessageSwitchToPendingNewAvatarFailed,
        NetMessageCoopStartEntranceFailed,
        NetMessageGuildMessageToClient,
        NetMessageEntityGuildInfo,
        NetMessageLeaveGuild,
        NetMessageGuildSystemMessage,
        NetMessageRegionDifficultyChange,
        NetMessageMetaGameWaveUpdate,
        NetMessagePvEInstanceCrystalUpdate,
        NetMessagePvEInstanceDeathUpdate,
        NetMessagePvEInstanceRegionScoreUpdate,
        NetMessageMetaGameBanner,
        NetMessagePostDialogToClient,
        NetMessageRemoveDialogFromClient,
        NetMessageCancelPendingActionToClient,
        NetMessageRecvAkEventFromEntity,
        NetMessageMatchQueueUpdateClient,
        GlobalEventCriteriaData,
        NetMessageGlobalEventDataUpdate,
        NetMessageGlobalEventLeaderboardUpdate,
        NetMessageOpenUIPanel,
        NetMessagePlayerOwnsItemResponse,
        NetMessageShowShareLegendaryMissionNotification,
        NetMessageShareLegendaryMissionResult,
        NetMessageUISyncDataUpdate,
        NetMessagePlayerTradeStatus,
        NetMessageUISyncDataRemove,
        AchievementDatabaseDump,
        NetMessageAchievementDatabaseDump,
        NetMessageAchievementStateUpdate,
        NetMessagePartyKickGracePeriod,
        NetMessageReceivedGift,
        NetMessageAchievementCompletedByPartyMember,
        NetMessageVerifyOnClient,
        NetMessageCreateAndOpenFileOnClient,
        NetMessageInventoryArchivedEntity,
        NetMessageInventoryLoaded,
        NetMessageLeaderboardReportClient,
        NetMessageLeaderboardCheatResponseClient,
        LeaderboardArchivedInstanceListData,
        LeaderboardInitData,
        NetMessageLeaderboardArchivedInstanceListResponse,
        NetMessageLeaderboardInitializeRequestResponse,
        NetMessageLeaderboardStateChange,
        NetMessageLeaderboardRewarded,
        NetMessageGiftHistoryResult,
        NetMessageStoreTooBusy,
        NetMessageSetDebuggingClient,
        NetMessageCoopOpResult,
        NetMessageAwardUpdate,
        NetMessageDisplayCouponNotifications,
        NetMessagePublicEventTeamAssigned,
        NetMessageRoutedClientMessageResponse,
        NetMessageGiftingRestrictionsUpdate,
        PartyOperationRequestClientResult,
        PartyInfoClientUpdate,
        PartyMemberInfoClientUpdate,
        NetMessagePlayerLookupByNameServerResponse,
        NetMessageSuggestedPlayerForParty
    }

    public enum GroupingManagerMessage : byte
    {
        ChatResponseToExternalLogin,
        ChatNormalMessage,
        ChatTellMessage,
        ChatBroadcastMessage,
        ChatErrorMessage,
        ChatBanVoteResponse,
        ChatCreateChatRoomResult,
        ChatAddPlayerToRoomResult,
        ChatScrubTextResult,
        ChatServerNotification,
        ChatClientIsLoggedIn
    }

    public enum GuildMessage : byte
    {
        GuildForm,
        GuildFormResult,
        GuildDisbanded,
        GuildChangeName,
        GuildChangeNameResult,
        GuildNameChanged,
        GuildChangeMotd,
        GuildChangeMotdResult,
        GuildMotdChanged,
        GuildMemberNameChanged,
        GuildInvite,
        GuildInviteResult,
        GuildInvitedToJoin,
        GuildRespondToInvite,
        GuildRespondToInviteResult,
        GuildMemberInfo,
        GuildChangeMember,
        GuildChangeMemberResult,
        GuildMembersInfoChanged,
        GuildCompleteInfo,
        GuildMessageSetToServer,
        GuildMessageSetToClient,
        GuildMessageSetToPlayerManager
    }

    public enum MatchCommonMessage : byte
    {
        MatchTeamDescription,
        MatchGameDescription,
        MatchQueueDescription,
        MatchTeamResultData,
        MatchResultData,
        MatchPlayerStatisticsSummary
    }

    public enum PubSubProtocolMessage : byte
    {
        PubSubPublish,
        PubSubSubscribe,
        PubSubEventNotification,
        PubSubOrderlyShutdown,
        PubSubForceLogRollover,
        PubSubServerStatusUpdate,
        PubSubServerStatusRequest
    }
}
