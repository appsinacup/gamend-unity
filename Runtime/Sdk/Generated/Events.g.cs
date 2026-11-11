// Written by clients/sdkgen (csharp) from the OpenAPI document.
// Do not edit; edit the generator or the spec and run
// clients/generate_csharp.sh.
//
// The realtime events, one constant each, and the table that names a socket
// message. OpenAPI does not describe the socket, so this comes from
// `clients/events.json`. An event the table does not name is `Message`.
namespace Gamend
{
    /// <summary>The realtime signals, and how a socket message maps to one.</summary>
    public static class Events
    {
        public const string AccountBanned = "account_banned";
        public const string AccountUnbanned = "account_unbanned";
        public const string ChatMuted = "chat_muted";
        public const string ChatUnmuted = "chat_unmuted";
        public const string FriendAdded = "friend_added";
        public const string FriendBlocked = "friend_blocked";
        public const string FriendChatMessage = "friend_chat_message";
        public const string FriendChatMessageDeleted = "friend_chat_message_deleted";
        public const string FriendChatMessageUpdated = "friend_chat_message_updated";
        public const string FriendRejected = "friend_rejected";
        public const string FriendRemoved = "friend_removed";
        public const string FriendRequestCancelled = "friend_request_cancelled";
        public const string FriendUnblocked = "friend_unblocked";
        public const string FriendUpdated = "friend_updated";
        public const string GroupChatMessage = "group_chat_message";
        public const string GroupChatMessageDeleted = "group_chat_message_deleted";
        public const string GroupChatMessageUpdated = "group_chat_message_updated";
        public const string GroupCreated = "group_created";
        public const string GroupDeleted = "group_deleted";
        public const string GroupInviteAccepted = "group_invite_accepted";
        public const string GroupInviteCancelled = "group_invite_cancelled";
        public const string GroupJoinRequestApproved = "group_join_request_approved";
        public const string GroupJoinRequestRejected = "group_join_request_rejected";
        public const string GroupListUpdated = "group_list_updated";
        public const string GroupMemberDemoted = "group_member_demoted";
        public const string GroupMemberJoined = "group_member_joined";
        public const string GroupMemberKicked = "group_member_kicked";
        public const string GroupMemberLeft = "group_member_left";
        public const string GroupMemberOffline = "group_member_offline";
        public const string GroupMemberOnline = "group_member_online";
        public const string GroupMemberPromoted = "group_member_promoted";
        public const string GroupMemberUpdated = "group_member_updated";
        public const string GroupUpdated = "group_updated";
        public const string InventoryUpdated = "inventory_updated";
        public const string KvDeleted = "kv_deleted";
        public const string KvUpdated = "kv_updated";
        public const string LobbyChatMessage = "lobby_chat_message";
        public const string LobbyChatMessageDeleted = "lobby_chat_message_deleted";
        public const string LobbyChatMessageUpdated = "lobby_chat_message_updated";
        public const string LobbyCreated = "lobby_created";
        public const string LobbyDeleted = "lobby_deleted";
        public const string LobbyHostChanged = "lobby_host_changed";
        public const string LobbyListUpdated = "lobby_list_updated";
        public const string LobbyMemberJoined = "lobby_member_joined";
        public const string LobbyMemberKicked = "lobby_member_kicked";
        public const string LobbyMemberLeft = "lobby_member_left";
        public const string LobbyMemberOffline = "lobby_member_offline";
        public const string LobbyMemberOnline = "lobby_member_online";
        public const string LobbyMemberUpdated = "lobby_member_updated";
        public const string LobbyMembershipChanged = "lobby_membership_changed";
        public const string LobbyResultEnded = "lobby_result_ended";
        public const string LobbyResultEvent = "lobby_result_event";
        public const string LobbyResultStarted = "lobby_result_started";
        public const string LobbyStateChanged = "lobby_state_changed";
        public const string LobbyUpdated = "lobby_updated";
        public const string MatchFound = "match_found";
        public const string NotificationEmitted = "notification_emitted";
        public const string PartyChatMessage = "party_chat_message";
        public const string PartyChatMessageDeleted = "party_chat_message_deleted";
        public const string PartyChatMessageUpdated = "party_chat_message_updated";
        public const string PartyDisbanded = "party_disbanded";
        public const string PartyInviteAccepted = "party_invite_accepted";
        public const string PartyInviteCancelled = "party_invite_cancelled";
        public const string PartyInviteDeclined = "party_invite_declined";
        public const string PartyMemberJoined = "party_member_joined";
        public const string PartyMemberLeft = "party_member_left";
        public const string PartyMemberOffline = "party_member_offline";
        public const string PartyMemberOnline = "party_member_online";
        public const string PartyMemberUpdated = "party_member_updated";
        public const string PartyUpdated = "party_updated";
        public const string QuestClaimed = "quest_claimed";
        public const string QuestCompleted = "quest_completed";
        public const string QuestProgress = "quest_progress";
        public const string ReadyCheckFailed = "ready_check_failed";
        public const string ReadyCheckPassed = "ready_check_passed";
        public const string ReadyCheckStarted = "ready_check_started";
        public const string ReadyCheckUpdated = "ready_check_updated";
        public const string ResultEnded = "result_ended";
        public const string ResultEvent = "result_event";
        public const string ResultStarted = "result_started";
        public const string SignalingAnswer = "signaling_answer";
        public const string SignalingIce = "signaling_ice";
        public const string SignalingOffer = "signaling_offer";
        public const string SignalingRoomClosed = "signaling_room_closed";
        public const string SignalingUserJoined = "signaling_user_joined";
        public const string SignalingUserLeft = "signaling_user_left";
        public const string SignalingUserRejoined = "signaling_user_rejoined";
        public const string TicketCancelled = "ticket_cancelled";
        public const string TicketQueued = "ticket_queued";
        public const string TournamentFinished = "tournament_finished";
        public const string TournamentMatchReady = "tournament_match_ready";
        public const string TournamentMatchResolved = "tournament_match_resolved";
        public const string TournamentUpdated = "tournament_updated";
        public const string UserUpdated = "user_updated";
        public const string WalletUpdated = "wallet_updated";
        public const string WebrtcAnswer = "webrtc_answer";
        public const string WebrtcChannelClosed = "webrtc_channel_closed";
        public const string WebrtcChannelOpen = "webrtc_channel_open";
        public const string WebrtcIce = "webrtc_ice";
        public const string WebrtcState = "webrtc_state";
        public const string Message = "message";

        /// <summary>One row of the table: the channel a topic belongs to, the event the
        /// server sends on it, and the signal this SDK calls it.</summary>
        public sealed class Row
        {
            public string Channel { get; }
            public string Event { get; }
            public string Signal { get; }

            internal Row(string channel, string eventName, string signal)
            {
                Channel = channel;
                Event = eventName;
                Signal = signal;
            }
        }

        public static readonly Row[] Table =
        {
            new Row("user", "updated", "user_updated"),
            new Row("user", "notification_created", "notification_emitted"),
            new Row("user", "friend_updated", "friend_updated"),
            new Row("user", "kv_updated", "kv_updated"),
            new Row("user", "kv_deleted", "kv_deleted"),
            new Row("user", "wallet_updated", "wallet_updated"),
            new Row("user", "inventory_updated", "inventory_updated"),
            new Row("user", "result_started", "result_started"),
            new Row("user", "result_event", "result_event"),
            new Row("user", "result_ended", "result_ended"),
            new Row("user", "chat_message_created", "friend_chat_message"),
            new Row("user", "chat_message_updated", "friend_chat_message_updated"),
            new Row("user", "chat_message_deleted", "friend_chat_message_deleted"),
            new Row("user", "chat_muted", "chat_muted"),
            new Row("user", "chat_unmuted", "chat_unmuted"),
            new Row("user", "account_banned", "account_banned"),
            new Row("user", "account_unbanned", "account_unbanned"),
            new Row("user", "quest_progress", "quest_progress"),
            new Row("user", "quest_completed", "quest_completed"),
            new Row("user", "quest_claimed", "quest_claimed"),
            new Row("user", "group_invite_accepted", "group_invite_accepted"),
            new Row("user", "group_invite_cancelled", "group_invite_cancelled"),
            new Row("user", "group_join_request_approved", "group_join_request_approved"),
            new Row("user", "group_join_request_rejected", "group_join_request_rejected"),
            new Row("user", "party_invite_accepted", "party_invite_accepted"),
            new Row("user", "party_invite_cancelled", "party_invite_cancelled"),
            new Row("user", "party_invite_declined", "party_invite_declined"),
            new Row("user", "match_found", "match_found"),
            new Row("user", "ticket_queued", "ticket_queued"),
            new Row("user", "ticket_cancelled", "ticket_cancelled"),
            new Row("user", "ready_check_started", "ready_check_started"),
            new Row("user", "ready_check_updated", "ready_check_updated"),
            new Row("user", "ready_check_passed", "ready_check_passed"),
            new Row("user", "ready_check_failed", "ready_check_failed"),
            new Row("user", "outgoing_request", "friend_added"),
            new Row("user", "incoming_request", "friend_added"),
            new Row("user", "request_cancelled", "friend_request_cancelled"),
            new Row("user", "friend_accepted", "friend_added"),
            new Row("user", "friend_rejected", "friend_rejected"),
            new Row("user", "friend_removed", "friend_removed"),
            new Row("user", "friend_blocked", "friend_blocked"),
            new Row("user", "friend_unblocked", "friend_unblocked"),
            new Row("user", "tournament_updated", "tournament_updated"),
            new Row("user", "tournament_finished", "tournament_finished"),
            new Row("user", "tournament_match_ready", "tournament_match_ready"),
            new Row("user", "tournament_match_resolved", "tournament_match_resolved"),
            new Row("user", "webrtc:answer", "webrtc_answer"),
            new Row("user", "webrtc:ice", "webrtc_ice"),
            new Row("user", "webrtc:channel_open", "webrtc_channel_open"),
            new Row("user", "webrtc:channel_closed", "webrtc_channel_closed"),
            new Row("user", "webrtc:state", "webrtc_state"),
            new Row("lobby", "updated", "lobby_updated"),
            new Row("lobby", "user_joined", "lobby_member_joined"),
            new Row("lobby", "user_left", "lobby_member_left"),
            new Row("lobby", "user_kicked", "lobby_member_kicked"),
            new Row("lobby", "user_online", "lobby_member_online"),
            new Row("lobby", "user_offline", "lobby_member_offline"),
            new Row("lobby", "user_updated", "lobby_member_updated"),
            new Row("lobby", "host_changed", "lobby_host_changed"),
            new Row("lobby", "state_changed", "lobby_state_changed"),
            new Row("lobby", "ready_check_started", "ready_check_started"),
            new Row("lobby", "ready_check_updated", "ready_check_updated"),
            new Row("lobby", "ready_check_passed", "ready_check_passed"),
            new Row("lobby", "ready_check_failed", "ready_check_failed"),
            new Row("lobby", "chat_message_created", "lobby_chat_message"),
            new Row("lobby", "chat_message_updated", "lobby_chat_message_updated"),
            new Row("lobby", "chat_message_deleted", "lobby_chat_message_deleted"),
            new Row("lobby", "result_started", "lobby_result_started"),
            new Row("lobby", "result_event", "lobby_result_event"),
            new Row("lobby", "result_ended", "lobby_result_ended"),
            new Row("lobbies", "lobby_created", "lobby_created"),
            new Row("lobbies", "lobby_updated", "lobby_list_updated"),
            new Row("lobbies", "lobby_deleted", "lobby_deleted"),
            new Row("lobbies", "lobby_membership_changed", "lobby_membership_changed"),
            new Row("group", "updated", "group_updated"),
            new Row("group", "member_joined", "group_member_joined"),
            new Row("group", "member_left", "group_member_left"),
            new Row("group", "member_kicked", "group_member_kicked"),
            new Row("group", "member_promoted", "group_member_promoted"),
            new Row("group", "member_demoted", "group_member_demoted"),
            new Row("group", "member_online", "group_member_online"),
            new Row("group", "member_offline", "group_member_offline"),
            new Row("group", "member_updated", "group_member_updated"),
            new Row("group", "join_request_approved", "group_join_request_approved"),
            new Row("group", "join_request_rejected", "group_join_request_rejected"),
            new Row("group", "chat_message_created", "group_chat_message"),
            new Row("group", "chat_message_updated", "group_chat_message_updated"),
            new Row("group", "chat_message_deleted", "group_chat_message_deleted"),
            new Row("groups", "group_created", "group_created"),
            new Row("groups", "group_updated", "group_list_updated"),
            new Row("groups", "group_deleted", "group_deleted"),
            new Row("party", "updated", "party_updated"),
            new Row("party", "member_joined", "party_member_joined"),
            new Row("party", "member_left", "party_member_left"),
            new Row("party", "member_online", "party_member_online"),
            new Row("party", "member_offline", "party_member_offline"),
            new Row("party", "member_updated", "party_member_updated"),
            new Row("party", "disbanded", "party_disbanded"),
            new Row("party", "ready_check_started", "ready_check_started"),
            new Row("party", "ready_check_updated", "ready_check_updated"),
            new Row("party", "ready_check_passed", "ready_check_passed"),
            new Row("party", "ready_check_failed", "ready_check_failed"),
            new Row("party", "chat_message_created", "party_chat_message"),
            new Row("party", "chat_message_updated", "party_chat_message_updated"),
            new Row("party", "chat_message_deleted", "party_chat_message_deleted"),
            new Row("signaling", "user_joined", "signaling_user_joined"),
            new Row("signaling", "user_rejoined", "signaling_user_rejoined"),
            new Row("signaling", "user_left", "signaling_user_left"),
            new Row("signaling", "offer", "signaling_offer"),
            new Row("signaling", "answer", "signaling_answer"),
            new Row("signaling", "ice", "signaling_ice"),
            new Row("signaling", "room_closed", "signaling_room_closed"),
        };

        /// <summary>The channel a topic names: `lobby:12` is `lobby`, `lobbies` is itself.</summary>
        public static string ChannelOf(string topic)
        {
            var colon = topic.IndexOf(':');
            return colon < 0 ? topic : topic.Substring(0, colon);
        }

        /// <summary>The signal a message on `topic` named `eventName` is, or `Message`.</summary>
        public static string SignalOf(string topic, string eventName)
        {
            var channel = ChannelOf(topic);
            foreach (var row in Table)
            {
                if (row.Channel == channel && row.Event == eventName) return row.Signal;
            }
            return Message;
        }
    }
}
