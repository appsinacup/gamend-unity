// Written by clients/sdkgen (csharp) from the OpenAPI document.
// Do not edit; edit the generator or the spec and run
// clients/generate_csharp.sh.
//
// Every message of proto/gamend_realtime.proto as a field table, which
// Proto.cs decodes the wire format against.
namespace Gamend
{
    internal static partial class Proto
    {
        private static readonly Field[] FieldsLinkedProviders =
        {
            new Field(1, "google", Label.Singular, FieldType.Bool, -1),
            new Field(2, "facebook", Label.Singular, FieldType.Bool, -1),
            new Field(3, "discord", Label.Singular, FieldType.Bool, -1),
            new Field(4, "apple", Label.Singular, FieldType.Bool, -1),
            new Field(5, "steam", Label.Singular, FieldType.Bool, -1),
            new Field(6, "device", Label.Singular, FieldType.Bool, -1),
            new Field(7, "github", Label.Singular, FieldType.Bool, -1),
        };

        private static readonly Field[] FieldsUser =
        {
            new Field(1, "id", Label.Optional, FieldType.String, -1),
            new Field(2, "email", Label.Optional, FieldType.String, -1),
            new Field(3, "profile_url", Label.Optional, FieldType.String, -1),
            new Field(4, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(5, "display_name", Label.Optional, FieldType.String, -1),
            new Field(6, "lobby_id", Label.Optional, FieldType.String, -1),
            new Field(7, "party_id", Label.Optional, FieldType.String, -1),
            new Field(8, "is_online", Label.Optional, FieldType.Bool, -1),
            new Field(9, "last_seen_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(10, "linked_providers", Label.Optional, FieldType.Message, 0),
            new Field(11, "has_password", Label.Optional, FieldType.Bool, -1),
            new Field(12, "metadata_pb", Label.Optional, FieldType.Bytes, -1),
            new Field(13, "username", Label.Optional, FieldType.String, -1),
        };

        private static readonly Field[] FieldsFriendUpdate =
        {
            new Field(1, "friends", Label.Map, FieldType.Message, 1),
        };

        private static readonly Field[] FieldsUserBrief =
        {
            new Field(1, "id", Label.Optional, FieldType.String, -1),
            new Field(2, "display_name", Label.Optional, FieldType.String, -1),
            new Field(3, "profile_url", Label.Optional, FieldType.String, -1),
            new Field(4, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(5, "is_online", Label.Optional, FieldType.Bool, -1),
            new Field(6, "is_activated", Label.Optional, FieldType.Bool, -1),
            new Field(7, "last_seen_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(8, "metadata_pb", Label.Optional, FieldType.Bytes, -1),
            new Field(9, "username", Label.Optional, FieldType.String, -1),
        };

        private static readonly Field[] FieldsNotification =
        {
            new Field(1, "id", Label.Singular, FieldType.String, -1),
            new Field(2, "sender_id", Label.Singular, FieldType.String, -1),
            new Field(3, "sender_name", Label.Singular, FieldType.String, -1),
            new Field(4, "recipient_id", Label.Singular, FieldType.String, -1),
            new Field(5, "title", Label.Singular, FieldType.String, -1),
            new Field(6, "content", Label.Singular, FieldType.String, -1),
            new Field(7, "metadata_json", Label.Singular, FieldType.Bytes, -1),
            new Field(8, "inserted_at_ms", Label.Singular, FieldType.Int64, -1),
            new Field(9, "icon_url", Label.Singular, FieldType.String, -1),
            new Field(10, "group", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsChatMessage =
        {
            new Field(1, "id", Label.Singular, FieldType.String, -1),
            new Field(2, "content", Label.Singular, FieldType.String, -1),
            new Field(3, "metadata_json", Label.Singular, FieldType.Bytes, -1),
            new Field(4, "sender_id", Label.Singular, FieldType.String, -1),
            new Field(5, "sender_name", Label.Singular, FieldType.String, -1),
            new Field(6, "chat_type", Label.Singular, FieldType.String, -1),
            new Field(7, "chat_ref_id", Label.Singular, FieldType.String, -1),
            new Field(8, "inserted_at_ms", Label.Singular, FieldType.Int64, -1),
            new Field(9, "updated_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(10, "sender_email", Label.Optional, FieldType.String, -1),
        };

        private static readonly Field[] FieldsQuestProgress =
        {
            new Field(1, "id", Label.Singular, FieldType.String, -1),
            new Field(2, "user_id", Label.Singular, FieldType.String, -1),
            new Field(3, "quest_key", Label.Singular, FieldType.String, -1),
            new Field(4, "period_key", Label.Singular, FieldType.String, -1),
            new Field(5, "objective_progress", Label.Map, FieldType.Int64, -1),
            new Field(6, "status", Label.Singular, FieldType.String, -1),
            new Field(7, "completed_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(8, "claimed_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(9, "metadata_json", Label.Singular, FieldType.Bytes, -1),
            new Field(10, "inserted_at_ms", Label.Singular, FieldType.Int64, -1),
            new Field(11, "updated_at_ms", Label.Singular, FieldType.Int64, -1),
        };

        private static readonly Field[] FieldsLobby =
        {
            new Field(1, "id", Label.Optional, FieldType.String, -1),
            new Field(2, "title", Label.Optional, FieldType.String, -1),
            new Field(3, "host_id", Label.Optional, FieldType.String, -1),
            new Field(4, "host_name", Label.Optional, FieldType.String, -1),
            new Field(5, "hostless", Label.Optional, FieldType.Bool, -1),
            new Field(6, "max_users", Label.Optional, FieldType.Int32, -1),
            new Field(7, "is_hidden", Label.Optional, FieldType.Bool, -1),
            new Field(8, "is_locked", Label.Optional, FieldType.Bool, -1),
            new Field(9, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(10, "is_passworded", Label.Optional, FieldType.Bool, -1),
            new Field(11, "slowdown", Label.Optional, FieldType.Int32, -1),
            new Field(12, "spectator_count", Label.Optional, FieldType.Int32, -1),
            new Field(13, "members", Label.Repeated, FieldType.Message, 3),
            new Field(14, "has_members", Label.Optional, FieldType.Bool, -1),
            new Field(15, "metadata_pb", Label.Optional, FieldType.Bytes, -1),
            new Field(16, "state", Label.Optional, FieldType.String, -1),
            new Field(17, "state_changed_at_ms", Label.Optional, FieldType.Int64, -1),
        };

        private static readonly Field[] FieldsGroup =
        {
            new Field(1, "id", Label.Optional, FieldType.String, -1),
            new Field(2, "title", Label.Optional, FieldType.String, -1),
            new Field(3, "description", Label.Optional, FieldType.String, -1),
            new Field(4, "type", Label.Optional, FieldType.String, -1),
            new Field(5, "max_members", Label.Optional, FieldType.Int32, -1),
            new Field(6, "creator_id", Label.Optional, FieldType.String, -1),
            new Field(7, "creator_name", Label.Optional, FieldType.String, -1),
            new Field(8, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(9, "member_count", Label.Optional, FieldType.Int32, -1),
            new Field(10, "slowdown", Label.Optional, FieldType.Int32, -1),
            new Field(11, "inserted_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(12, "updated_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(13, "metadata_pb", Label.Optional, FieldType.Bytes, -1),
            new Field(14, "icon_url", Label.Optional, FieldType.String, -1),
            new Field(15, "slug", Label.Optional, FieldType.String, -1),
        };

        private static readonly Field[] FieldsParty =
        {
            new Field(1, "id", Label.Optional, FieldType.String, -1),
            new Field(2, "leader_id", Label.Optional, FieldType.String, -1),
            new Field(3, "leader_name", Label.Optional, FieldType.String, -1),
            new Field(4, "max_size", Label.Optional, FieldType.Int32, -1),
            new Field(5, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(6, "members", Label.Repeated, FieldType.Message, 3),
            new Field(7, "has_members", Label.Optional, FieldType.Bool, -1),
            new Field(8, "inserted_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(9, "updated_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(10, "metadata_pb", Label.Optional, FieldType.Bytes, -1),
        };

        private static readonly Field[] FieldsMemberEvent =
        {
            new Field(1, "user_id", Label.Singular, FieldType.String, -1),
            new Field(2, "display_name", Label.Optional, FieldType.String, -1),
            new Field(3, "id", Label.Optional, FieldType.String, -1),
            new Field(4, "profile_url", Label.Optional, FieldType.String, -1),
            new Field(5, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(6, "is_online", Label.Optional, FieldType.Bool, -1),
            new Field(7, "is_activated", Label.Optional, FieldType.Bool, -1),
            new Field(8, "last_seen_at_ms", Label.Optional, FieldType.Int64, -1),
            new Field(9, "group_id", Label.Optional, FieldType.String, -1),
            new Field(10, "metadata_pb", Label.Optional, FieldType.Bytes, -1),
            new Field(11, "username", Label.Optional, FieldType.String, -1),
        };

        private static readonly Field[] FieldsEntityId =
        {
            new Field(1, "id", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsPartyRef =
        {
            new Field(1, "party_id", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsHostChanged =
        {
            new Field(1, "new_host_id", Label.Singular, FieldType.String, -1),
            new Field(2, "display_name", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsLobbyStateChanged =
        {
            new Field(1, "lobby_id", Label.Singular, FieldType.String, -1),
            new Field(2, "from", Label.Singular, FieldType.String, -1),
            new Field(3, "to", Label.Singular, FieldType.String, -1),
            new Field(4, "state_changed_at_ms", Label.Optional, FieldType.Int64, -1),
        };

        private static readonly Field[] FieldsGroupInviteEvent =
        {
            new Field(1, "group_id", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsPartyInviteEvent =
        {
            new Field(1, "party_id", Label.Singular, FieldType.String, -1),
            new Field(2, "user_id", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsWalletChange =
        {
            new Field(1, "currency", Label.Singular, FieldType.String, -1),
            new Field(2, "balance", Label.Singular, FieldType.Int64, -1),
            new Field(3, "delta", Label.Singular, FieldType.Sint64, -1),
        };

        private static readonly Field[] FieldsInventoryChange =
        {
            new Field(1, "item_code", Label.Singular, FieldType.String, -1),
            new Field(2, "quantity", Label.Singular, FieldType.Int64, -1),
            new Field(3, "delta", Label.Singular, FieldType.Sint64, -1),
        };

        private static readonly Field[] FieldsChatMute =
        {
            new Field(1, "scope", Label.Singular, FieldType.String, -1),
            new Field(2, "scope_ref_id", Label.Singular, FieldType.String, -1),
            new Field(3, "expires_at_seconds", Label.Singular, FieldType.Int64, -1),
            new Field(4, "reason", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsChatUnmute =
        {
            new Field(1, "scope", Label.Singular, FieldType.String, -1),
            new Field(2, "scope_ref_id", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsTournamentEvent =
        {
            new Field(1, "tournament_id", Label.Singular, FieldType.String, -1),
            new Field(2, "slug", Label.Singular, FieldType.String, -1),
            new Field(3, "state", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsTournamentMatchEvent =
        {
            new Field(1, "tournament_id", Label.Singular, FieldType.String, -1),
            new Field(2, "slug", Label.Singular, FieldType.String, -1),
            new Field(3, "match_id", Label.Singular, FieldType.String, -1),
            new Field(4, "round", Label.Singular, FieldType.Int32, -1),
            new Field(5, "deadline_at_ms", Label.Singular, FieldType.Int64, -1),
            new Field(6, "winner_entry_id", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsMatchmakingFound =
        {
            new Field(1, "lobby_id", Label.Singular, FieldType.String, -1),
            new Field(2, "match_params", Label.Map, FieldType.String, -1),
        };

        private static readonly Field[] FieldsMatchmakingTicketQueued =
        {
            new Field(1, "ticket_id", Label.Singular, FieldType.String, -1),
            new Field(2, "match_params", Label.Map, FieldType.String, -1),
            new Field(3, "queued_at_ms", Label.Singular, FieldType.Int64, -1),
            new Field(4, "requeued", Label.Singular, FieldType.Bool, -1),
        };

        private static readonly Field[] FieldsMatchmakingTicketCancelled =
        {
            new Field(1, "ticket_id", Label.Singular, FieldType.String, -1),
            new Field(2, "reason", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsReadyCheckParticipant =
        {
            new Field(1, "user_id", Label.Singular, FieldType.String, -1),
            new Field(2, "display_name", Label.Singular, FieldType.String, -1),
            new Field(3, "state", Label.Singular, FieldType.String, -1),
            new Field(4, "responded_at_ms", Label.Singular, FieldType.Int64, -1),
        };

        private static readonly Field[] FieldsReadyCheckState =
        {
            new Field(1, "id", Label.Singular, FieldType.String, -1),
            new Field(2, "kind", Label.Singular, FieldType.String, -1),
            new Field(3, "status", Label.Singular, FieldType.String, -1),
            new Field(4, "lobby_id", Label.Singular, FieldType.String, -1),
            new Field(5, "deadline_at_ms", Label.Singular, FieldType.Int64, -1),
            new Field(6, "total", Label.Singular, FieldType.Int32, -1),
            new Field(7, "ready_count", Label.Singular, FieldType.Int32, -1),
            new Field(8, "your_state", Label.Singular, FieldType.String, -1),
            new Field(9, "reason", Label.Singular, FieldType.String, -1),
            new Field(10, "participants", Label.Repeated, FieldType.Message, 26),
            new Field(11, "party_id", Label.Singular, FieldType.String, -1),
            new Field(12, "opened_by", Label.Singular, FieldType.String, -1),
            new Field(13, "metadata_json", Label.Singular, FieldType.Bytes, -1),
        };

        private static readonly Field[] FieldsKvEntry =
        {
            new Field(1, "key", Label.Singular, FieldType.String, -1),
            new Field(2, "user_id", Label.Optional, FieldType.String, -1),
            new Field(3, "lobby_id", Label.Optional, FieldType.String, -1),
            new Field(4, "data_json", Label.Optional, FieldType.Bytes, -1),
            new Field(5, "metadata_json", Label.Optional, FieldType.Bytes, -1),
            new Field(6, "data_pb", Label.Optional, FieldType.Bytes, -1),
        };

        private static readonly Field[] FieldsRpcCall =
        {
            new Field(1, "id", Label.Singular, FieldType.Uint32, -1),
            new Field(2, "plugin", Label.Singular, FieldType.String, -1),
            new Field(3, "fn", Label.Singular, FieldType.String, -1),
            new Field(4, "args_json", Label.Optional, FieldType.Bytes, -1),
            new Field(5, "args_raw", Label.Optional, FieldType.Bytes, -1),
        };

        private static readonly Field[] FieldsRpcReply =
        {
            new Field(1, "id", Label.Singular, FieldType.Uint32, -1),
            new Field(2, "data_json", Label.Optional, FieldType.Bytes, -1),
            new Field(3, "data_raw", Label.Optional, FieldType.Bytes, -1),
        };

        private static readonly Field[] FieldsRpcError =
        {
            new Field(1, "id", Label.Singular, FieldType.Uint32, -1),
            new Field(2, "error", Label.Singular, FieldType.String, -1),
        };

        private static readonly Field[] FieldsRtcEnvelope =
        {
            new Field(1, "call_hook", Label.Optional, FieldType.Message, 29),
            new Field(2, "hook_reply", Label.Optional, FieldType.Message, 30),
            new Field(3, "hook_error", Label.Optional, FieldType.Message, 31),
        };

        internal static readonly Message[] Messages =
        {
            new Message("LinkedProviders", FieldsLinkedProviders),
            new Message("User", FieldsUser),
            new Message("FriendUpdate", FieldsFriendUpdate),
            new Message("UserBrief", FieldsUserBrief),
            new Message("Notification", FieldsNotification),
            new Message("ChatMessage", FieldsChatMessage),
            new Message("QuestProgress", FieldsQuestProgress),
            new Message("Lobby", FieldsLobby),
            new Message("Group", FieldsGroup),
            new Message("Party", FieldsParty),
            new Message("MemberEvent", FieldsMemberEvent),
            new Message("EntityId", FieldsEntityId),
            new Message("PartyRef", FieldsPartyRef),
            new Message("HostChanged", FieldsHostChanged),
            new Message("LobbyStateChanged", FieldsLobbyStateChanged),
            new Message("GroupInviteEvent", FieldsGroupInviteEvent),
            new Message("PartyInviteEvent", FieldsPartyInviteEvent),
            new Message("WalletChange", FieldsWalletChange),
            new Message("InventoryChange", FieldsInventoryChange),
            new Message("ChatMute", FieldsChatMute),
            new Message("ChatUnmute", FieldsChatUnmute),
            new Message("TournamentEvent", FieldsTournamentEvent),
            new Message("TournamentMatchEvent", FieldsTournamentMatchEvent),
            new Message("MatchmakingFound", FieldsMatchmakingFound),
            new Message("MatchmakingTicketQueued", FieldsMatchmakingTicketQueued),
            new Message("MatchmakingTicketCancelled", FieldsMatchmakingTicketCancelled),
            new Message("ReadyCheckParticipant", FieldsReadyCheckParticipant),
            new Message("ReadyCheckState", FieldsReadyCheckState),
            new Message("KvEntry", FieldsKvEntry),
            new Message("RpcCall", FieldsRpcCall),
            new Message("RpcReply", FieldsRpcReply),
            new Message("RpcError", FieldsRpcError),
            new Message("RtcEnvelope", FieldsRtcEnvelope),
        };
    }
}
