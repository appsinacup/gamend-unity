// Written by clients/sdkgen (csharp) from the OpenAPI document.
// Do not edit; edit the generator or the spec and run
// clients/generate_csharp.sh.
//
// The reader and the writer of every model, written out field by field: no
// reflection, nothing for IL2CPP to strip. Reads are lenient and never throw:
// a field that is missing or of the wrong type keeps its default.
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Gamend.Models
{
    public static partial class Codec
    {
        public static bool ReadAccountBan(JToken j, out AccountBan value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new AccountBan();
            v.ExpiresAt = Field<string>(o, "expires_at", ReadString, v.ExpiresAt);
            v.Reason = Field<string>(o, "reason", ReadString, v.Reason);
            value = v;
            return true;
        }

        public static JToken WriteAccountBan(AccountBan v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["expires_at"] = WriteString(v.ExpiresAt);
            j["reason"] = WriteString(v.Reason);
            return j;
        }

        public static bool ReadActivityStats(JToken j, out ActivityStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ActivityStats();
            v.Dau = Field<long>(o, "dau", ReadLong, v.Dau);
            v.Mau = Field<long>(o, "mau", ReadLong, v.Mau);
            v.NewUsers1d = Field<long>(o, "new_users_1d", ReadLong, v.NewUsers1d);
            v.NewUsers30d = Field<long>(o, "new_users_30d", ReadLong, v.NewUsers30d);
            v.NewUsers7d = Field<long>(o, "new_users_7d", ReadLong, v.NewUsers7d);
            v.Wau = Field<long>(o, "wau", ReadLong, v.Wau);
            value = v;
            return true;
        }

        public static JToken WriteActivityStats(ActivityStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["dau"] = WriteLong(v.Dau);
            j["mau"] = WriteLong(v.Mau);
            j["new_users_1d"] = WriteLong(v.NewUsers1d);
            j["new_users_30d"] = WriteLong(v.NewUsers30d);
            j["new_users_7d"] = WriteLong(v.NewUsers7d);
            j["wau"] = WriteLong(v.Wau);
            return j;
        }

        public static bool ReadUserBrief(JToken j, out UserBrief value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new UserBrief();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.IsActivated = Field<bool>(o, "is_activated", ReadBool, v.IsActivated);
            v.IsOnline = Field<bool>(o, "is_online", ReadBool, v.IsOnline);
            v.LastSeenAt = Field<string>(o, "last_seen_at", ReadString, v.LastSeenAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.ProfileUrl = Field<string>(o, "profile_url", ReadString, v.ProfileUrl);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteUserBrief(UserBrief v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["id"] = WriteString(v.Id);
            j["is_activated"] = WriteBool(v.IsActivated);
            j["is_online"] = WriteBool(v.IsOnline);
            j["last_seen_at"] = WriteString(v.LastSeenAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["profile_url"] = WriteString(v.ProfileUrl);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadBlockedFriendship(JToken j, out BlockedFriendship value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new BlockedFriendship();
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Requester = Field<UserBrief>(o, "requester", ReadUserBrief, v.Requester);
            value = v;
            return true;
        }

        public static JToken WriteBlockedFriendship(BlockedFriendship v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["id"] = WriteString(v.Id);
            j["requester"] = WriteUserBrief(v.Requester);
            return j;
        }

        public static bool ReadCancelledCount(JToken j, out CancelledCount value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new CancelledCount();
            v.Cancelled = Field<long>(o, "cancelled", ReadLong, v.Cancelled);
            value = v;
            return true;
        }

        public static JToken WriteCancelledCount(CancelledCount v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["cancelled"] = WriteLong(v.Cancelled);
            return j;
        }

        public static bool ReadChatMessage(JToken j, out ChatMessage value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ChatMessage();
            v.ChatRefId = Field<string>(o, "chat_ref_id", ReadString, v.ChatRefId);
            v.ChatType = Field<string>(o, "chat_type", ReadString, v.ChatType);
            v.Content = Field<string>(o, "content", ReadString, v.Content);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.SenderEmail = Field<string>(o, "sender_email", ReadString, v.SenderEmail);
            v.SenderId = Field<string>(o, "sender_id", ReadString, v.SenderId);
            v.SenderName = Field<string>(o, "sender_name", ReadString, v.SenderName);
            v.UpdatedAt = Field<string>(o, "updated_at", ReadString, v.UpdatedAt);
            value = v;
            return true;
        }

        public static JToken WriteChatMessage(ChatMessage v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["chat_ref_id"] = WriteString(v.ChatRefId);
            j["chat_type"] = WriteString(v.ChatType);
            j["content"] = WriteString(v.Content);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["sender_email"] = WriteString(v.SenderEmail);
            j["sender_id"] = WriteString(v.SenderId);
            j["sender_name"] = WriteString(v.SenderName);
            j["updated_at"] = WriteString(v.UpdatedAt);
            return j;
        }

        public static bool ReadChatMuteRecord(JToken j, out ChatMuteRecord value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ChatMuteRecord();
            v.ExpiresAt = Field<string>(o, "expires_at", ReadString, v.ExpiresAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.MutedBy = Field<string>(o, "muted_by", ReadString, v.MutedBy);
            v.Reason = Field<string>(o, "reason", ReadString, v.Reason);
            v.Scope = Field<string>(o, "scope", ReadString, v.Scope);
            v.ScopeRefId = Field<string>(o, "scope_ref_id", ReadString, v.ScopeRefId);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            value = v;
            return true;
        }

        public static JToken WriteChatMuteRecord(ChatMuteRecord v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["expires_at"] = WriteString(v.ExpiresAt);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["muted_by"] = WriteString(v.MutedBy);
            j["reason"] = WriteString(v.Reason);
            j["scope"] = WriteString(v.Scope);
            j["scope_ref_id"] = WriteString(v.ScopeRefId);
            j["user_id"] = WriteString(v.UserId);
            return j;
        }

        public static bool ReadChatReadCursor(JToken j, out ChatReadCursor value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ChatReadCursor();
            v.ChatRefId = Field<string>(o, "chat_ref_id", ReadString, v.ChatRefId);
            v.ChatType = Field<string>(o, "chat_type", ReadString, v.ChatType);
            v.LastReadMessageId = Field<string>(o, "last_read_message_id", ReadString, v.LastReadMessageId);
            v.UpdatedAt = Field<string>(o, "updated_at", ReadString, v.UpdatedAt);
            value = v;
            return true;
        }

        public static JToken WriteChatReadCursor(ChatReadCursor v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["chat_ref_id"] = WriteString(v.ChatRefId);
            j["chat_type"] = WriteString(v.ChatType);
            j["last_read_message_id"] = WriteString(v.LastReadMessageId);
            j["updated_at"] = WriteString(v.UpdatedAt);
            return j;
        }

        public static bool ReadChatUnread(JToken j, out ChatUnread value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ChatUnread();
            v.UnreadCount = Field<long>(o, "unread_count", ReadLong, v.UnreadCount);
            value = v;
            return true;
        }

        public static JToken WriteChatUnread(ChatUnread v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["unread_count"] = WriteLong(v.UnreadCount);
            return j;
        }

        public static bool ReadClientLogEntry(JToken j, out ClientLogEntry value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ClientLogEntry();
            v.At = Field<double>(o, "at", ReadDouble, v.At);
            v.Category = Field<string>(o, "category", ReadString, v.Category);
            v.Level = Field<string>(o, "level", ReadString, v.Level);
            v.LobbyId = Field<string>(o, "lobby_id", ReadString, v.LobbyId);
            v.Message = Field<string>(o, "message", ReadString, v.Message);
            v.Screen = Field<string>(o, "screen", ReadString, v.Screen);
            v.Seq = Field<long>(o, "seq", ReadLong, v.Seq);
            value = v;
            return true;
        }

        public static JToken WriteClientLogEntry(ClientLogEntry v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["at"] = WriteDouble(v.At);
            j["category"] = WriteString(v.Category);
            j["level"] = WriteString(v.Level);
            j["lobby_id"] = WriteString(v.LobbyId);
            j["message"] = WriteString(v.Message);
            j["screen"] = WriteString(v.Screen);
            j["seq"] = WriteLong(v.Seq);
            return j;
        }

        public static bool ReadClientLogSession(JToken j, out ClientLogSession value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ClientLogSession();
            v.AppVersion = Field<string>(o, "app_version", ReadString, v.AppVersion);
            v.Build = Field<string>(o, "build", ReadString, v.Build);
            v.ClientSessionId = Field<string>(o, "client_session_id", ReadString, v.ClientSessionId);
            v.DeviceId = Field<string>(o, "device_id", ReadString, v.DeviceId);
            v.Locale = Field<string>(o, "locale", ReadString, v.Locale);
            v.Meta = Field<JToken>(o, "meta", ReadToken, v.Meta);
            v.Platform = Field<string>(o, "platform", ReadString, v.Platform);
            v.StartedAt = Field<double>(o, "started_at", ReadDouble, v.StartedAt);
            value = v;
            return true;
        }

        public static JToken WriteClientLogSession(ClientLogSession v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["app_version"] = WriteString(v.AppVersion);
            j["build"] = WriteString(v.Build);
            j["client_session_id"] = WriteString(v.ClientSessionId);
            j["device_id"] = WriteString(v.DeviceId);
            j["locale"] = WriteString(v.Locale);
            j["meta"] = WriteToken(v.Meta);
            j["platform"] = WriteString(v.Platform);
            j["started_at"] = WriteDouble(v.StartedAt);
            return j;
        }

        public static bool ReadClientLogBatch(JToken j, out ClientLogBatch value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ClientLogBatch();
            v.Entries = Field<List<ClientLogEntry>>(o, "entries", ListOf<ClientLogEntry>(ReadClientLogEntry), v.Entries);
            v.Session = Field<ClientLogSession>(o, "session", ReadClientLogSession, v.Session);
            value = v;
            return true;
        }

        public static JToken WriteClientLogBatch(ClientLogBatch v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["entries"] = ListWriter<ClientLogEntry>(WriteClientLogEntry)(v.Entries);
            j["session"] = WriteClientLogSession(v.Session);
            return j;
        }

        public static bool ReadClientLogPolicy(JToken j, out ClientLogPolicy value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ClientLogPolicy();
            v.BatchMax = Field<long>(o, "batch_max", ReadLong, v.BatchMax);
            v.Categories = Field<Dictionary<string, string>>(o, "categories", MapOf<string>(ReadString), v.Categories);
            v.Enabled = Field<bool>(o, "enabled", ReadBool, v.Enabled);
            v.Level = Field<string>(o, "level", ReadString, v.Level);
            v.MessageMaxBytes = Field<long>(o, "message_max_bytes", ReadLong, v.MessageMaxBytes);
            value = v;
            return true;
        }

        public static JToken WriteClientLogPolicy(ClientLogPolicy v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["batch_max"] = WriteLong(v.BatchMax);
            j["categories"] = MapWriter<string>(WriteString)(v.Categories);
            j["enabled"] = WriteBool(v.Enabled);
            j["level"] = WriteString(v.Level);
            j["message_max_bytes"] = WriteLong(v.MessageMaxBytes);
            return j;
        }

        public static bool ReadClientLogResult(JToken j, out ClientLogResult value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ClientLogResult();
            v.Accepted = Field<long>(o, "accepted", ReadLong, v.Accepted);
            v.ClientSessionId = Field<string>(o, "client_session_id", ReadString, v.ClientSessionId);
            v.Dropped = Field<long>(o, "dropped", ReadLong, v.Dropped);
            v.Errors = Field<long>(o, "errors", ReadLong, v.Errors);
            value = v;
            return true;
        }

        public static JToken WriteClientLogResult(ClientLogResult v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["accepted"] = WriteLong(v.Accepted);
            j["client_session_id"] = WriteString(v.ClientSessionId);
            j["dropped"] = WriteLong(v.Dropped);
            j["errors"] = WriteLong(v.Errors);
            return j;
        }

        public static bool ReadLinkedProviders(JToken j, out LinkedProviders value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new LinkedProviders();
            v.Apple = Field<bool>(o, "apple", ReadBool, v.Apple);
            v.Device = Field<bool>(o, "device", ReadBool, v.Device);
            v.Discord = Field<bool>(o, "discord", ReadBool, v.Discord);
            v.Facebook = Field<bool>(o, "facebook", ReadBool, v.Facebook);
            v.Github = Field<bool>(o, "github", ReadBool, v.Github);
            v.Google = Field<bool>(o, "google", ReadBool, v.Google);
            v.Steam = Field<bool>(o, "steam", ReadBool, v.Steam);
            value = v;
            return true;
        }

        public static JToken WriteLinkedProviders(LinkedProviders v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["apple"] = WriteBool(v.Apple);
            j["device"] = WriteBool(v.Device);
            j["discord"] = WriteBool(v.Discord);
            j["facebook"] = WriteBool(v.Facebook);
            j["github"] = WriteBool(v.Github);
            j["google"] = WriteBool(v.Google);
            j["steam"] = WriteBool(v.Steam);
            return j;
        }

        public static bool ReadCurrentUser(JToken j, out CurrentUser value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new CurrentUser();
            v.Ban = Field<AccountBan>(o, "ban", ReadAccountBan, v.Ban);
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.Email = Field<string>(o, "email", ReadString, v.Email);
            v.HasPassword = Field<bool>(o, "has_password", ReadBool, v.HasPassword);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.IsOnline = Field<bool>(o, "is_online", ReadBool, v.IsOnline);
            v.LastSeenAt = Field<string>(o, "last_seen_at", ReadString, v.LastSeenAt);
            v.LinkedProviders = Field<LinkedProviders>(o, "linked_providers", ReadLinkedProviders, v.LinkedProviders);
            v.LobbyId = Field<string>(o, "lobby_id", ReadString, v.LobbyId);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.PartyId = Field<string>(o, "party_id", ReadString, v.PartyId);
            v.ProfileUrl = Field<string>(o, "profile_url", ReadString, v.ProfileUrl);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteCurrentUser(CurrentUser v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["ban"] = WriteAccountBan(v.Ban);
            j["display_name"] = WriteString(v.DisplayName);
            j["email"] = WriteString(v.Email);
            j["has_password"] = WriteBool(v.HasPassword);
            j["id"] = WriteString(v.Id);
            j["is_online"] = WriteBool(v.IsOnline);
            j["last_seen_at"] = WriteString(v.LastSeenAt);
            j["linked_providers"] = WriteLinkedProviders(v.LinkedProviders);
            j["lobby_id"] = WriteString(v.LobbyId);
            j["metadata"] = WriteToken(v.Metadata);
            j["party_id"] = WriteString(v.PartyId);
            j["profile_url"] = WriteString(v.ProfileUrl);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadDeletedCount(JToken j, out DeletedCount value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new DeletedCount();
            v.Deleted = Field<long>(o, "deleted", ReadLong, v.Deleted);
            value = v;
            return true;
        }

        public static JToken WriteDeletedCount(DeletedCount v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["deleted"] = WriteLong(v.Deleted);
            return j;
        }

        public static bool ReadEntitlement(JToken j, out Entitlement value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Entitlement();
            v.ExpiresAt = Field<string>(o, "expires_at", ReadString, v.ExpiresAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Key = Field<string>(o, "key", ReadString, v.Key);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.ProductId = Field<string>(o, "product_id", ReadString, v.ProductId);
            v.RevokedAt = Field<string>(o, "revoked_at", ReadString, v.RevokedAt);
            v.SourcePurchaseId = Field<string>(o, "source_purchase_id", ReadString, v.SourcePurchaseId);
            v.StartsAt = Field<string>(o, "starts_at", ReadString, v.StartsAt);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteEntitlement(Entitlement v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["expires_at"] = WriteString(v.ExpiresAt);
            j["id"] = WriteString(v.Id);
            j["key"] = WriteString(v.Key);
            j["metadata"] = WriteToken(v.Metadata);
            j["product_id"] = WriteString(v.ProductId);
            j["revoked_at"] = WriteString(v.RevokedAt);
            j["source_purchase_id"] = WriteString(v.SourcePurchaseId);
            j["starts_at"] = WriteString(v.StartsAt);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadErrorResponse(JToken j, out ErrorResponse value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ErrorResponse();
            v.Error = Field<string>(o, "error", ReadString, v.Error);
            v.Errors = Field<Dictionary<string, List<string>>>(o, "errors", MapOf<List<string>>(ListOf<string>(ReadString)), v.Errors);
            v.Message = Field<string>(o, "message", ReadString, v.Message);
            value = v;
            return true;
        }

        public static JToken WriteErrorResponse(ErrorResponse v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["error"] = WriteString(v.Error);
            j["errors"] = MapWriter<List<string>>(ListWriter<string>(WriteString))(v.Errors);
            j["message"] = WriteString(v.Message);
            return j;
        }

        public static bool ReadFriend(JToken j, out Friend value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Friend();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.FriendshipId = Field<string>(o, "friendship_id", ReadString, v.FriendshipId);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.IsActivated = Field<bool>(o, "is_activated", ReadBool, v.IsActivated);
            v.IsOnline = Field<bool>(o, "is_online", ReadBool, v.IsOnline);
            v.LastSeenAt = Field<string>(o, "last_seen_at", ReadString, v.LastSeenAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.ProfileUrl = Field<string>(o, "profile_url", ReadString, v.ProfileUrl);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteFriend(Friend v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["friendship_id"] = WriteString(v.FriendshipId);
            j["id"] = WriteString(v.Id);
            j["is_activated"] = WriteBool(v.IsActivated);
            j["is_online"] = WriteBool(v.IsOnline);
            j["last_seen_at"] = WriteString(v.LastSeenAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["profile_url"] = WriteString(v.ProfileUrl);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadFriendRequest(JToken j, out FriendRequest value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new FriendRequest();
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.Requester = Field<UserBrief>(o, "requester", ReadUserBrief, v.Requester);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            v.Target = Field<UserBrief>(o, "target", ReadUserBrief, v.Target);
            value = v;
            return true;
        }

        public static JToken WriteFriendRequest(FriendRequest v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["requester"] = WriteUserBrief(v.Requester);
            j["status"] = WriteString(v.Status);
            j["target"] = WriteUserBrief(v.Target);
            return j;
        }

        public static bool ReadFriendRequestLists(JToken j, out FriendRequestLists value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new FriendRequestLists();
            v.Incoming = Field<List<FriendRequest>>(o, "incoming", ListOf<FriendRequest>(ReadFriendRequest), v.Incoming);
            v.Outgoing = Field<List<FriendRequest>>(o, "outgoing", ListOf<FriendRequest>(ReadFriendRequest), v.Outgoing);
            value = v;
            return true;
        }

        public static JToken WriteFriendRequestLists(FriendRequestLists v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["incoming"] = ListWriter<FriendRequest>(WriteFriendRequest)(v.Incoming);
            j["outgoing"] = ListWriter<FriendRequest>(WriteFriendRequest)(v.Outgoing);
            return j;
        }

        public static bool ReadPageMeta(JToken j, out PageMeta value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PageMeta();
            v.Count = Field<long>(o, "count", ReadLong, v.Count);
            v.HasMore = Field<bool>(o, "has_more", ReadBool, v.HasMore);
            v.Page = Field<long>(o, "page", ReadLong, v.Page);
            v.PageSize = Field<long>(o, "page_size", ReadLong, v.PageSize);
            v.TotalCount = Field<long>(o, "total_count", ReadLong, v.TotalCount);
            v.TotalPages = Field<long>(o, "total_pages", ReadLong, v.TotalPages);
            value = v;
            return true;
        }

        public static JToken WritePageMeta(PageMeta v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["count"] = WriteLong(v.Count);
            j["has_more"] = WriteBool(v.HasMore);
            j["page"] = WriteLong(v.Page);
            j["page_size"] = WriteLong(v.PageSize);
            j["total_count"] = WriteLong(v.TotalCount);
            j["total_pages"] = WriteLong(v.TotalPages);
            return j;
        }

        public static bool ReadFriendRequestMeta(JToken j, out FriendRequestMeta value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new FriendRequestMeta();
            v.Incoming = Field<PageMeta>(o, "incoming", ReadPageMeta, v.Incoming);
            v.Outgoing = Field<PageMeta>(o, "outgoing", ReadPageMeta, v.Outgoing);
            value = v;
            return true;
        }

        public static JToken WriteFriendRequestMeta(FriendRequestMeta v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["incoming"] = WritePageMeta(v.Incoming);
            j["outgoing"] = WritePageMeta(v.Outgoing);
            return j;
        }

        public static bool ReadGroup(JToken j, out Group value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Group();
            v.CreatorId = Field<string>(o, "creator_id", ReadString, v.CreatorId);
            v.CreatorName = Field<string>(o, "creator_name", ReadString, v.CreatorName);
            v.Description = Field<string>(o, "description", ReadString, v.Description);
            v.IconUrl = Field<string>(o, "icon_url", ReadString, v.IconUrl);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.MaxMembers = Field<long>(o, "max_members", ReadLong, v.MaxMembers);
            v.MemberCount = Field<long>(o, "member_count", ReadLong, v.MemberCount);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Slowdown = Field<long>(o, "slowdown", ReadLong, v.Slowdown);
            v.Slug = Field<string>(o, "slug", ReadString, v.Slug);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            v.Type = Field<string>(o, "type", ReadString, v.Type);
            v.UpdatedAt = Field<string>(o, "updated_at", ReadString, v.UpdatedAt);
            value = v;
            return true;
        }

        public static JToken WriteGroup(Group v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["creator_id"] = WriteString(v.CreatorId);
            j["creator_name"] = WriteString(v.CreatorName);
            j["description"] = WriteString(v.Description);
            j["icon_url"] = WriteString(v.IconUrl);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["max_members"] = WriteLong(v.MaxMembers);
            j["member_count"] = WriteLong(v.MemberCount);
            j["metadata"] = WriteToken(v.Metadata);
            j["slowdown"] = WriteLong(v.Slowdown);
            j["slug"] = WriteString(v.Slug);
            j["title"] = WriteString(v.Title);
            j["type"] = WriteString(v.Type);
            j["updated_at"] = WriteString(v.UpdatedAt);
            return j;
        }

        public static bool ReadGroupInvite(JToken j, out GroupInvite value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new GroupInvite();
            v.GroupId = Field<string>(o, "group_id", ReadString, v.GroupId);
            v.GroupTitle = Field<string>(o, "group_title", ReadString, v.GroupTitle);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.RecipientId = Field<string>(o, "recipient_id", ReadString, v.RecipientId);
            v.RecipientName = Field<string>(o, "recipient_name", ReadString, v.RecipientName);
            v.RecipientProfileUrl = Field<string>(o, "recipient_profile_url", ReadString, v.RecipientProfileUrl);
            v.SenderId = Field<string>(o, "sender_id", ReadString, v.SenderId);
            v.SenderName = Field<string>(o, "sender_name", ReadString, v.SenderName);
            v.SenderProfileUrl = Field<string>(o, "sender_profile_url", ReadString, v.SenderProfileUrl);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteGroupInvite(GroupInvite v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["group_id"] = WriteString(v.GroupId);
            j["group_title"] = WriteString(v.GroupTitle);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["recipient_id"] = WriteString(v.RecipientId);
            j["recipient_name"] = WriteString(v.RecipientName);
            j["recipient_profile_url"] = WriteString(v.RecipientProfileUrl);
            j["sender_id"] = WriteString(v.SenderId);
            j["sender_name"] = WriteString(v.SenderName);
            j["sender_profile_url"] = WriteString(v.SenderProfileUrl);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadGroupInviteLink(JToken j, out GroupInviteLink value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new GroupInviteLink();
            v.ExpiresAt = Field<string>(o, "expires_at", ReadString, v.ExpiresAt);
            v.GroupId = Field<string>(o, "group_id", ReadString, v.GroupId);
            v.Token = Field<string>(o, "token", ReadString, v.Token);
            v.Url = Field<string>(o, "url", ReadString, v.Url);
            v.Uses = Field<long>(o, "uses", ReadLong, v.Uses);
            value = v;
            return true;
        }

        public static JToken WriteGroupInviteLink(GroupInviteLink v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["expires_at"] = WriteString(v.ExpiresAt);
            j["group_id"] = WriteString(v.GroupId);
            j["token"] = WriteString(v.Token);
            j["url"] = WriteString(v.Url);
            j["uses"] = WriteLong(v.Uses);
            return j;
        }

        public static bool ReadGroupInviteLinkPreview(JToken j, out GroupInviteLinkPreview value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new GroupInviteLinkPreview();
            v.CreatorName = Field<string>(o, "creator_name", ReadString, v.CreatorName);
            v.ExpiresAt = Field<string>(o, "expires_at", ReadString, v.ExpiresAt);
            v.GroupId = Field<string>(o, "group_id", ReadString, v.GroupId);
            v.GroupTitle = Field<string>(o, "group_title", ReadString, v.GroupTitle);
            v.GroupType = Field<string>(o, "group_type", ReadString, v.GroupType);
            v.Member = Field<bool>(o, "member", ReadBool, v.Member);
            v.MemberCount = Field<long>(o, "member_count", ReadLong, v.MemberCount);
            value = v;
            return true;
        }

        public static JToken WriteGroupInviteLinkPreview(GroupInviteLinkPreview v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["creator_name"] = WriteString(v.CreatorName);
            j["expires_at"] = WriteString(v.ExpiresAt);
            j["group_id"] = WriteString(v.GroupId);
            j["group_title"] = WriteString(v.GroupTitle);
            j["group_type"] = WriteString(v.GroupType);
            j["member"] = WriteBool(v.Member);
            j["member_count"] = WriteLong(v.MemberCount);
            return j;
        }

        public static bool ReadGroupInviteOutcome(JToken j, out GroupInviteOutcome value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new GroupInviteOutcome();
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteGroupInviteOutcome(GroupInviteOutcome v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadGroupJoinRequest(JToken j, out GroupJoinRequest value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new GroupJoinRequest();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.GroupId = Field<string>(o, "group_id", ReadString, v.GroupId);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteGroupJoinRequest(GroupJoinRequest v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["group_id"] = WriteString(v.GroupId);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["status"] = WriteString(v.Status);
            j["user_id"] = WriteString(v.UserId);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadGroupMember(JToken j, out GroupMember value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new GroupMember();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.GroupId = Field<string>(o, "group_id", ReadString, v.GroupId);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.IsOnline = Field<bool>(o, "is_online", ReadBool, v.IsOnline);
            v.LastSeenAt = Field<string>(o, "last_seen_at", ReadString, v.LastSeenAt);
            v.ProfileUrl = Field<string>(o, "profile_url", ReadString, v.ProfileUrl);
            v.Role = Field<string>(o, "role", ReadString, v.Role);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteGroupMember(GroupMember v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["group_id"] = WriteString(v.GroupId);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["is_online"] = WriteBool(v.IsOnline);
            j["last_seen_at"] = WriteString(v.LastSeenAt);
            j["profile_url"] = WriteString(v.ProfileUrl);
            j["role"] = WriteString(v.Role);
            j["user_id"] = WriteString(v.UserId);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadHealth(JToken j, out Health value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Health();
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            v.Timestamp = Field<string>(o, "timestamp", ReadString, v.Timestamp);
            value = v;
            return true;
        }

        public static JToken WriteHealth(Health v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["status"] = WriteString(v.Status);
            j["timestamp"] = WriteString(v.Timestamp);
            return j;
        }

        public static bool ReadHookSignature(JToken j, out HookSignature value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new HookSignature();
            v.Arity = Field<long>(o, "arity", ReadLong, v.Arity);
            v.Doc = Field<string>(o, "doc", ReadString, v.Doc);
            v.ExampleArgs = Field<string>(o, "example_args", ReadString, v.ExampleArgs);
            v.Signature = Field<string>(o, "signature", ReadString, v.Signature);
            value = v;
            return true;
        }

        public static JToken WriteHookSignature(HookSignature v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["arity"] = WriteLong(v.Arity);
            j["doc"] = WriteString(v.Doc);
            j["example_args"] = WriteString(v.ExampleArgs);
            j["signature"] = WriteString(v.Signature);
            return j;
        }

        public static bool ReadHookFunction(JToken j, out HookFunction value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new HookFunction();
            v.Arities = Field<List<long>>(o, "arities", ListOf<long>(ReadLong), v.Arities);
            v.Dynamic = Field<bool>(o, "dynamic", ReadBool, v.Dynamic);
            v.Fn = Field<string>(o, "fn", ReadString, v.Fn);
            v.Meta = Field<JToken>(o, "meta", ReadToken, v.Meta);
            v.Plugin = Field<string>(o, "plugin", ReadString, v.Plugin);
            v.Signatures = Field<List<HookSignature>>(o, "signatures", ListOf<HookSignature>(ReadHookSignature), v.Signatures);
            value = v;
            return true;
        }

        public static JToken WriteHookFunction(HookFunction v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["arities"] = ListWriter<long>(WriteLong)(v.Arities);
            j["dynamic"] = WriteBool(v.Dynamic);
            j["fn"] = WriteString(v.Fn);
            j["meta"] = WriteToken(v.Meta);
            j["plugin"] = WriteString(v.Plugin);
            j["signatures"] = ListWriter<HookSignature>(WriteHookSignature)(v.Signatures);
            return j;
        }

        public static bool ReadInventory(JToken j, out Inventory value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            value = new Inventory();
            Fill<long>(o, value, ReadLong);
            return true;
        }

        public static JToken WriteInventory(Inventory v)
        {
            return MapWriter<long>(WriteLong)(v);
        }

        public static bool ReadKvEntry(JToken j, out KvEntry value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new KvEntry();
            v.Data = Field<JToken>(o, "data", ReadToken, v.Data);
            v.Key = Field<string>(o, "key", ReadString, v.Key);
            v.LobbyId = Field<string>(o, "lobby_id", ReadString, v.LobbyId);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            value = v;
            return true;
        }

        public static JToken WriteKvEntry(KvEntry v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["data"] = WriteToken(v.Data);
            j["key"] = WriteString(v.Key);
            j["lobby_id"] = WriteString(v.LobbyId);
            j["metadata"] = WriteToken(v.Metadata);
            j["user_id"] = WriteString(v.UserId);
            return j;
        }

        public static bool ReadLeaderboard(JToken j, out Leaderboard value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Leaderboard();
            v.Description = Field<string>(o, "description", ReadString, v.Description);
            v.EndsAt = Field<string>(o, "ends_at", ReadString, v.EndsAt);
            v.IconUrl = Field<string>(o, "icon_url", ReadString, v.IconUrl);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.IsActive = Field<bool>(o, "is_active", ReadBool, v.IsActive);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Operator = Field<string>(o, "operator", ReadString, v.Operator);
            v.Slug = Field<string>(o, "slug", ReadString, v.Slug);
            v.SortOrder = Field<string>(o, "sort_order", ReadString, v.SortOrder);
            v.StartsAt = Field<string>(o, "starts_at", ReadString, v.StartsAt);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            v.UpdatedAt = Field<string>(o, "updated_at", ReadString, v.UpdatedAt);
            value = v;
            return true;
        }

        public static JToken WriteLeaderboard(Leaderboard v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["description"] = WriteString(v.Description);
            j["ends_at"] = WriteString(v.EndsAt);
            j["icon_url"] = WriteString(v.IconUrl);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["is_active"] = WriteBool(v.IsActive);
            j["metadata"] = WriteToken(v.Metadata);
            j["operator"] = WriteString(v.Operator);
            j["slug"] = WriteString(v.Slug);
            j["sort_order"] = WriteString(v.SortOrder);
            j["starts_at"] = WriteString(v.StartsAt);
            j["title"] = WriteString(v.Title);
            j["updated_at"] = WriteString(v.UpdatedAt);
            return j;
        }

        public static bool ReadLeaderboardKeys(JToken j, out LeaderboardKeys value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new LeaderboardKeys();
            v.Keys = Field<List<string>>(o, "keys", ListOf<string>(ReadString), v.Keys);
            value = v;
            return true;
        }

        public static JToken WriteLeaderboardKeys(LeaderboardKeys v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["keys"] = ListWriter<string>(WriteString)(v.Keys);
            return j;
        }

        public static bool ReadLeaderboardRecord(JToken j, out LeaderboardRecord value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new LeaderboardRecord();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.Hidden = Field<bool>(o, "hidden", ReadBool, v.Hidden);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Rank = Field<long>(o, "rank", ReadLong, v.Rank);
            v.Score = Field<long>(o, "score", ReadLong, v.Score);
            v.UpdatedAt = Field<string>(o, "updated_at", ReadString, v.UpdatedAt);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteLeaderboardRecord(LeaderboardRecord v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["hidden"] = WriteBool(v.Hidden);
            j["metadata"] = WriteToken(v.Metadata);
            j["rank"] = WriteLong(v.Rank);
            j["score"] = WriteLong(v.Score);
            j["updated_at"] = WriteString(v.UpdatedAt);
            j["user_id"] = WriteString(v.UserId);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadLeaderboardsBySlug(JToken j, out LeaderboardsBySlug value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            value = new LeaderboardsBySlug();
            Fill<Leaderboard>(o, value, ReadLeaderboard);
            return true;
        }

        public static JToken WriteLeaderboardsBySlug(LeaderboardsBySlug v)
        {
            return MapWriter<Leaderboard>(WriteLeaderboard)(v);
        }

        public static bool ReadLedgerEntry(JToken j, out LedgerEntry value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new LedgerEntry();
            v.BalanceAfter = Field<long>(o, "balance_after", ReadLong, v.BalanceAfter);
            v.Currency = Field<string>(o, "currency", ReadString, v.Currency);
            v.Delta = Field<long>(o, "delta", ReadLong, v.Delta);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Reason = Field<string>(o, "reason", ReadString, v.Reason);
            value = v;
            return true;
        }

        public static JToken WriteLedgerEntry(LedgerEntry v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["balance_after"] = WriteLong(v.BalanceAfter);
            j["currency"] = WriteString(v.Currency);
            j["delta"] = WriteLong(v.Delta);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["reason"] = WriteString(v.Reason);
            return j;
        }

        public static bool ReadLobby(JToken j, out Lobby value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Lobby();
            v.HostId = Field<string>(o, "host_id", ReadString, v.HostId);
            v.HostName = Field<string>(o, "host_name", ReadString, v.HostName);
            v.Hostless = Field<bool>(o, "hostless", ReadBool, v.Hostless);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.IsHidden = Field<bool>(o, "is_hidden", ReadBool, v.IsHidden);
            v.IsLocked = Field<bool>(o, "is_locked", ReadBool, v.IsLocked);
            v.IsPassworded = Field<bool>(o, "is_passworded", ReadBool, v.IsPassworded);
            v.MaxUsers = Field<long>(o, "max_users", ReadLong, v.MaxUsers);
            v.Members = Field<List<UserBrief>>(o, "members", ListOf<UserBrief>(ReadUserBrief), v.Members);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Slowdown = Field<long>(o, "slowdown", ReadLong, v.Slowdown);
            v.SpectatorCount = Field<long>(o, "spectator_count", ReadLong, v.SpectatorCount);
            v.State = Field<string>(o, "state", ReadString, v.State);
            v.StateChangedAt = Field<string>(o, "state_changed_at", ReadString, v.StateChangedAt);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            value = v;
            return true;
        }

        public static JToken WriteLobby(Lobby v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["host_id"] = WriteString(v.HostId);
            j["host_name"] = WriteString(v.HostName);
            j["hostless"] = WriteBool(v.Hostless);
            j["id"] = WriteString(v.Id);
            j["is_hidden"] = WriteBool(v.IsHidden);
            j["is_locked"] = WriteBool(v.IsLocked);
            j["is_passworded"] = WriteBool(v.IsPassworded);
            j["max_users"] = WriteLong(v.MaxUsers);
            j["members"] = ListWriter<UserBrief>(WriteUserBrief)(v.Members);
            j["metadata"] = WriteToken(v.Metadata);
            j["slowdown"] = WriteLong(v.Slowdown);
            j["spectator_count"] = WriteLong(v.SpectatorCount);
            j["state"] = WriteString(v.State);
            j["state_changed_at"] = WriteString(v.StateChangedAt);
            j["title"] = WriteString(v.Title);
            return j;
        }

        public static bool ReadLobbyStats(JToken j, out LobbyStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new LobbyStats();
            v.ByState = Field<Dictionary<string, long>>(o, "by_state", MapOf<long>(ReadLong), v.ByState);
            v.LobbiesTotal = Field<long>(o, "lobbies_total", ReadLong, v.LobbiesTotal);
            v.Spectators = Field<long>(o, "spectators", ReadLong, v.Spectators);
            value = v;
            return true;
        }

        public static JToken WriteLobbyStats(LobbyStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["by_state"] = MapWriter<long>(WriteLong)(v.ByState);
            j["lobbies_total"] = WriteLong(v.LobbiesTotal);
            j["spectators"] = WriteLong(v.Spectators);
            return j;
        }

        public static bool ReadMatchmakingQueue(JToken j, out MatchmakingQueue value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new MatchmakingQueue();
            v.Params = Field<Dictionary<string, string>>(o, "params", MapOf<string>(ReadString), v.Params);
            v.Waiting = Field<long>(o, "waiting", ReadLong, v.Waiting);
            value = v;
            return true;
        }

        public static JToken WriteMatchmakingQueue(MatchmakingQueue v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["params"] = MapWriter<string>(WriteString)(v.Params);
            j["waiting"] = WriteLong(v.Waiting);
            return j;
        }

        public static bool ReadMatchmakingStats(JToken j, out MatchmakingStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new MatchmakingStats();
            v.Queued = Field<long>(o, "queued", ReadLong, v.Queued);
            v.Queues = Field<List<MatchmakingQueue>>(o, "queues", ListOf<MatchmakingQueue>(ReadMatchmakingQueue), v.Queues);
            value = v;
            return true;
        }

        public static JToken WriteMatchmakingStats(MatchmakingStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["queued"] = WriteLong(v.Queued);
            j["queues"] = ListWriter<MatchmakingQueue>(WriteMatchmakingQueue)(v.Queues);
            return j;
        }

        public static bool ReadMatchmakingTicket(JToken j, out MatchmakingTicket value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new MatchmakingTicket();
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.LobbyId = Field<string>(o, "lobby_id", ReadString, v.LobbyId);
            v.MatchId = Field<string>(o, "match_id", ReadString, v.MatchId);
            v.MatchParams = Field<Dictionary<string, string>>(o, "match_params", MapOf<string>(ReadString), v.MatchParams);
            v.MatchedAt = Field<string>(o, "matched_at", ReadString, v.MatchedAt);
            v.MaxPlayers = Field<long>(o, "max_players", ReadLong, v.MaxPlayers);
            v.MinPlayers = Field<long>(o, "min_players", ReadLong, v.MinPlayers);
            v.QueuedAt = Field<string>(o, "queued_at", ReadString, v.QueuedAt);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            v.TimeoutMs = Field<long>(o, "timeout_ms", ReadLong, v.TimeoutMs);
            value = v;
            return true;
        }

        public static JToken WriteMatchmakingTicket(MatchmakingTicket v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["id"] = WriteString(v.Id);
            j["lobby_id"] = WriteString(v.LobbyId);
            j["match_id"] = WriteString(v.MatchId);
            j["match_params"] = MapWriter<string>(WriteString)(v.MatchParams);
            j["matched_at"] = WriteString(v.MatchedAt);
            j["max_players"] = WriteLong(v.MaxPlayers);
            j["min_players"] = WriteLong(v.MinPlayers);
            j["queued_at"] = WriteString(v.QueuedAt);
            j["status"] = WriteString(v.Status);
            j["timeout_ms"] = WriteLong(v.TimeoutMs);
            return j;
        }

        public static bool ReadReadyCheckParticipant(JToken j, out ReadyCheckParticipant value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ReadyCheckParticipant();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.RespondedAt = Field<string>(o, "responded_at", ReadString, v.RespondedAt);
            v.State = Field<string>(o, "state", ReadString, v.State);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            value = v;
            return true;
        }

        public static JToken WriteReadyCheckParticipant(ReadyCheckParticipant v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["responded_at"] = WriteString(v.RespondedAt);
            j["state"] = WriteString(v.State);
            j["user_id"] = WriteString(v.UserId);
            return j;
        }

        public static bool ReadReadyCheckState(JToken j, out ReadyCheckState value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ReadyCheckState();
            v.DeadlineAt = Field<string>(o, "deadline_at", ReadString, v.DeadlineAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Kind = Field<string>(o, "kind", ReadString, v.Kind);
            v.LobbyId = Field<string>(o, "lobby_id", ReadString, v.LobbyId);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.OpenedBy = Field<string>(o, "opened_by", ReadString, v.OpenedBy);
            v.Participants = Field<List<ReadyCheckParticipant>>(o, "participants", ListOf<ReadyCheckParticipant>(ReadReadyCheckParticipant), v.Participants);
            v.PartyId = Field<string>(o, "party_id", ReadString, v.PartyId);
            v.ReadyCount = Field<long>(o, "ready_count", ReadLong, v.ReadyCount);
            v.Reason = Field<string>(o, "reason", ReadString, v.Reason);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            v.Total = Field<long>(o, "total", ReadLong, v.Total);
            v.YourState = Field<string>(o, "your_state", ReadString, v.YourState);
            value = v;
            return true;
        }

        public static JToken WriteReadyCheckState(ReadyCheckState v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["deadline_at"] = WriteString(v.DeadlineAt);
            j["id"] = WriteString(v.Id);
            j["kind"] = WriteString(v.Kind);
            j["lobby_id"] = WriteString(v.LobbyId);
            j["metadata"] = WriteToken(v.Metadata);
            j["opened_by"] = WriteString(v.OpenedBy);
            j["participants"] = ListWriter<ReadyCheckParticipant>(WriteReadyCheckParticipant)(v.Participants);
            j["party_id"] = WriteString(v.PartyId);
            j["ready_count"] = WriteLong(v.ReadyCount);
            j["reason"] = WriteString(v.Reason);
            j["status"] = WriteString(v.Status);
            j["total"] = WriteLong(v.Total);
            j["your_state"] = WriteString(v.YourState);
            return j;
        }

        public static bool ReadMyReadyChecks(JToken j, out MyReadyChecks value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new MyReadyChecks();
            v.Lobby = Field<ReadyCheckState>(o, "lobby", ReadReadyCheckState, v.Lobby);
            v.Party = Field<ReadyCheckState>(o, "party", ReadReadyCheckState, v.Party);
            value = v;
            return true;
        }

        public static JToken WriteMyReadyChecks(MyReadyChecks v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["lobby"] = WriteReadyCheckState(v.Lobby);
            j["party"] = WriteReadyCheckState(v.Party);
            return j;
        }

        public static bool ReadNotification(JToken j, out Notification value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Notification();
            v.Content = Field<string>(o, "content", ReadString, v.Content);
            v.Group = Field<string>(o, "group", ReadString, v.Group);
            v.IconUrl = Field<string>(o, "icon_url", ReadString, v.IconUrl);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.RecipientId = Field<string>(o, "recipient_id", ReadString, v.RecipientId);
            v.SenderId = Field<string>(o, "sender_id", ReadString, v.SenderId);
            v.SenderName = Field<string>(o, "sender_name", ReadString, v.SenderName);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            value = v;
            return true;
        }

        public static JToken WriteNotification(Notification v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["content"] = WriteString(v.Content);
            j["group"] = WriteString(v.Group);
            j["icon_url"] = WriteString(v.IconUrl);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["recipient_id"] = WriteString(v.RecipientId);
            j["sender_id"] = WriteString(v.SenderId);
            j["sender_name"] = WriteString(v.SenderName);
            j["title"] = WriteString(v.Title);
            return j;
        }

        public static bool ReadOAuthAuthorization(JToken j, out OAuthAuthorization value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new OAuthAuthorization();
            v.AuthorizationUrl = Field<string>(o, "authorization_url", ReadString, v.AuthorizationUrl);
            v.SessionId = Field<string>(o, "session_id", ReadString, v.SessionId);
            value = v;
            return true;
        }

        public static JToken WriteOAuthAuthorization(OAuthAuthorization v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["authorization_url"] = WriteString(v.AuthorizationUrl);
            j["session_id"] = WriteString(v.SessionId);
            return j;
        }

        public static bool ReadSession(JToken j, out Session value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Session();
            v.AccessToken = Field<string>(o, "access_token", ReadString, v.AccessToken);
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.ExpiresIn = Field<long>(o, "expires_in", ReadLong, v.ExpiresIn);
            v.RefreshToken = Field<string>(o, "refresh_token", ReadString, v.RefreshToken);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteSession(Session v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["access_token"] = WriteString(v.AccessToken);
            j["display_name"] = WriteString(v.DisplayName);
            j["expires_in"] = WriteLong(v.ExpiresIn);
            j["refresh_token"] = WriteString(v.RefreshToken);
            j["user_id"] = WriteString(v.UserId);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadOAuthSessionStatus(JToken j, out OAuthSessionStatus value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new OAuthSessionStatus();
            v.Error = Field<string>(o, "error", ReadString, v.Error);
            v.Message = Field<string>(o, "message", ReadString, v.Message);
            v.Session = Field<Session>(o, "session", ReadSession, v.Session);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteOAuthSessionStatus(OAuthSessionStatus v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["error"] = WriteString(v.Error);
            j["message"] = WriteString(v.Message);
            j["session"] = WriteSession(v.Session);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadOkResponse(JToken j, out OkResponse value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new OkResponse();
            v.Ok = Field<bool>(o, "ok", ReadBool, v.Ok);
            value = v;
            return true;
        }

        public static JToken WriteOkResponse(OkResponse v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["ok"] = WriteBool(v.Ok);
            return j;
        }

        public static bool ReadParty(JToken j, out Party value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Party();
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.LeaderId = Field<string>(o, "leader_id", ReadString, v.LeaderId);
            v.LeaderName = Field<string>(o, "leader_name", ReadString, v.LeaderName);
            v.MaxSize = Field<long>(o, "max_size", ReadLong, v.MaxSize);
            v.Members = Field<List<UserBrief>>(o, "members", ListOf<UserBrief>(ReadUserBrief), v.Members);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.UpdatedAt = Field<string>(o, "updated_at", ReadString, v.UpdatedAt);
            value = v;
            return true;
        }

        public static JToken WriteParty(Party v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["leader_id"] = WriteString(v.LeaderId);
            j["leader_name"] = WriteString(v.LeaderName);
            j["max_size"] = WriteLong(v.MaxSize);
            j["members"] = ListWriter<UserBrief>(WriteUserBrief)(v.Members);
            j["metadata"] = WriteToken(v.Metadata);
            j["updated_at"] = WriteString(v.UpdatedAt);
            return j;
        }

        public static bool ReadPartyInvite(JToken j, out PartyInvite value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PartyInvite();
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.PartyId = Field<string>(o, "party_id", ReadString, v.PartyId);
            v.RecipientId = Field<string>(o, "recipient_id", ReadString, v.RecipientId);
            v.RecipientName = Field<string>(o, "recipient_name", ReadString, v.RecipientName);
            v.SenderId = Field<string>(o, "sender_id", ReadString, v.SenderId);
            v.SenderName = Field<string>(o, "sender_name", ReadString, v.SenderName);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WritePartyInvite(PartyInvite v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["party_id"] = WriteString(v.PartyId);
            j["recipient_id"] = WriteString(v.RecipientId);
            j["recipient_name"] = WriteString(v.RecipientName);
            j["sender_id"] = WriteString(v.SenderId);
            j["sender_name"] = WriteString(v.SenderName);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadPartyStats(JToken j, out PartyStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PartyStats();
            v.PartiesActive = Field<long>(o, "parties_active", ReadLong, v.PartiesActive);
            v.PlayersInParties = Field<long>(o, "players_in_parties", ReadLong, v.PlayersInParties);
            value = v;
            return true;
        }

        public static JToken WritePartyStats(PartyStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["parties_active"] = WriteLong(v.PartiesActive);
            j["players_in_parties"] = WriteLong(v.PlayersInParties);
            return j;
        }

        public static bool ReadPaymentProduct(JToken j, out PaymentProduct value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PaymentProduct();
            v.Description = Field<string>(o, "description", ReadString, v.Description);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Kind = Field<string>(o, "kind", ReadString, v.Kind);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Sku = Field<string>(o, "sku", ReadString, v.Sku);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            value = v;
            return true;
        }

        public static JToken WritePaymentProduct(PaymentProduct v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["description"] = WriteString(v.Description);
            j["id"] = WriteString(v.Id);
            j["kind"] = WriteString(v.Kind);
            j["metadata"] = WriteToken(v.Metadata);
            j["sku"] = WriteString(v.Sku);
            j["title"] = WriteString(v.Title);
            return j;
        }

        public static bool ReadPaymentCatalogEntry(JToken j, out PaymentCatalogEntry value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PaymentCatalogEntry();
            v.Currency = Field<string>(o, "currency", ReadString, v.Currency);
            v.ExternalId = Field<string>(o, "external_id", ReadString, v.ExternalId);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Product = Field<PaymentProduct>(o, "product", ReadPaymentProduct, v.Product);
            v.Provider = Field<string>(o, "provider", ReadString, v.Provider);
            v.UnitAmount = Field<long?>(o, "unit_amount", Maybe<long>(ReadLong), v.UnitAmount);
            value = v;
            return true;
        }

        public static JToken WritePaymentCatalogEntry(PaymentCatalogEntry v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["currency"] = WriteString(v.Currency);
            j["external_id"] = WriteString(v.ExternalId);
            j["id"] = WriteString(v.Id);
            j["metadata"] = WriteToken(v.Metadata);
            j["product"] = WritePaymentProduct(v.Product);
            j["provider"] = WriteString(v.Provider);
            j["unit_amount"] = MaybeWriter<long>(WriteLong)(v.UnitAmount);
            return j;
        }

        public static bool ReadPaymentWebhookReceipt(JToken j, out PaymentWebhookReceipt value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PaymentWebhookReceipt();
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WritePaymentWebhookReceipt(PaymentWebhookReceipt v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadPlayResultStat(JToken j, out PlayResultStat value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PlayResultStat();
            v.Count = Field<long>(o, "count", ReadLong, v.Count);
            v.Sum = Field<double>(o, "sum", ReadDouble, v.Sum);
            value = v;
            return true;
        }

        public static JToken WritePlayResultStat(PlayResultStat v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["count"] = WriteLong(v.Count);
            j["sum"] = WriteDouble(v.Sum);
            return j;
        }

        public static bool ReadPlayResult(JToken j, out PlayResult value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PlayResult();
            v.EndedAt = Field<string>(o, "ended_at", ReadString, v.EndedAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Kind = Field<string>(o, "kind", ReadString, v.Kind);
            v.LobbyId = Field<string>(o, "lobby_id", ReadString, v.LobbyId);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.StartedAt = Field<string>(o, "started_at", ReadString, v.StartedAt);
            v.Stats = Field<Dictionary<string, PlayResultStat>>(o, "stats", MapOf<PlayResultStat>(ReadPlayResultStat), v.Stats);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            v.Visibility = Field<string>(o, "visibility", ReadString, v.Visibility);
            value = v;
            return true;
        }

        public static JToken WritePlayResult(PlayResult v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["ended_at"] = WriteString(v.EndedAt);
            j["id"] = WriteString(v.Id);
            j["kind"] = WriteString(v.Kind);
            j["lobby_id"] = WriteString(v.LobbyId);
            j["metadata"] = WriteToken(v.Metadata);
            j["started_at"] = WriteString(v.StartedAt);
            j["stats"] = MapWriter<PlayResultStat>(WritePlayResultStat)(v.Stats);
            j["status"] = WriteString(v.Status);
            j["user_id"] = WriteString(v.UserId);
            j["visibility"] = WriteString(v.Visibility);
            return j;
        }

        public static bool ReadPlayResultEvent(JToken j, out PlayResultEvent value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PlayResultEvent();
            v.ElapsedMs = Field<long>(o, "elapsed_ms", ReadLong, v.ElapsedMs);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Key = Field<string>(o, "key", ReadString, v.Key);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.ResultId = Field<string>(o, "result_id", ReadString, v.ResultId);
            v.Value = Field<double?>(o, "value", Maybe<double>(ReadDouble), v.Value);
            value = v;
            return true;
        }

        public static JToken WritePlayResultEvent(PlayResultEvent v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["elapsed_ms"] = WriteLong(v.ElapsedMs);
            j["id"] = WriteString(v.Id);
            j["key"] = WriteString(v.Key);
            j["metadata"] = WriteToken(v.Metadata);
            j["result_id"] = WriteString(v.ResultId);
            j["value"] = MaybeWriter<double>(WriteDouble)(v.Value);
            return j;
        }

        public static bool ReadPlayResultEvents(JToken j, out PlayResultEvents value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PlayResultEvents();
            v.Events = Field<List<PlayResultEvent>>(o, "events", ListOf<PlayResultEvent>(ReadPlayResultEvent), v.Events);
            v.ResultId = Field<string>(o, "result_id", ReadString, v.ResultId);
            value = v;
            return true;
        }

        public static JToken WritePlayResultEvents(PlayResultEvents v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["events"] = ListWriter<PlayResultEvent>(WritePlayResultEvent)(v.Events);
            j["result_id"] = WriteString(v.ResultId);
            return j;
        }

        public static bool ReadPlayerStats(JToken j, out PlayerStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PlayerStats();
            v.PlayersInLobbies = Field<long>(o, "players_in_lobbies", ReadLong, v.PlayersInLobbies);
            v.PlayersInParties = Field<long>(o, "players_in_parties", ReadLong, v.PlayersInParties);
            v.PlayersOffline = Field<long>(o, "players_offline", ReadLong, v.PlayersOffline);
            v.PlayersOnline = Field<long>(o, "players_online", ReadLong, v.PlayersOnline);
            v.PlayersTotal = Field<long>(o, "players_total", ReadLong, v.PlayersTotal);
            value = v;
            return true;
        }

        public static JToken WritePlayerStats(PlayerStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["players_in_lobbies"] = WriteLong(v.PlayersInLobbies);
            j["players_in_parties"] = WriteLong(v.PlayersInParties);
            j["players_offline"] = WriteLong(v.PlayersOffline);
            j["players_online"] = WriteLong(v.PlayersOnline);
            j["players_total"] = WriteLong(v.PlayersTotal);
            return j;
        }

        public static bool ReadProviderLinkStatus(JToken j, out ProviderLinkStatus value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ProviderLinkStatus();
            v.Error = Field<string>(o, "error", ReadString, v.Error);
            v.Message = Field<string>(o, "message", ReadString, v.Message);
            v.Provider = Field<string>(o, "provider", ReadString, v.Provider);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteProviderLinkStatus(ProviderLinkStatus v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["error"] = WriteString(v.Error);
            j["message"] = WriteString(v.Message);
            j["provider"] = WriteString(v.Provider);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadPublicUser(JToken j, out PublicUser value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PublicUser();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.IsActivated = Field<bool>(o, "is_activated", ReadBool, v.IsActivated);
            v.IsOnline = Field<bool>(o, "is_online", ReadBool, v.IsOnline);
            v.LastSeenAt = Field<string>(o, "last_seen_at", ReadString, v.LastSeenAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WritePublicUser(PublicUser v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["id"] = WriteString(v.Id);
            j["is_activated"] = WriteBool(v.IsActivated);
            j["is_online"] = WriteBool(v.IsOnline);
            j["last_seen_at"] = WriteString(v.LastSeenAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadPurchase(JToken j, out Purchase value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Purchase();
            v.Amount = Field<long?>(o, "amount", Maybe<long>(ReadLong), v.Amount);
            v.Currency = Field<string>(o, "currency", ReadString, v.Currency);
            v.Environment = Field<string>(o, "environment", ReadString, v.Environment);
            v.ExpiresAt = Field<string>(o, "expires_at", ReadString, v.ExpiresAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.OrderId = Field<string>(o, "order_id", ReadString, v.OrderId);
            v.ProductId = Field<string>(o, "product_id", ReadString, v.ProductId);
            v.Provider = Field<string>(o, "provider", ReadString, v.Provider);
            v.ProviderProductId = Field<string>(o, "provider_product_id", ReadString, v.ProviderProductId);
            v.ProviderTransactionId = Field<string>(o, "provider_transaction_id", ReadString, v.ProviderTransactionId);
            v.PurchasedAt = Field<string>(o, "purchased_at", ReadString, v.PurchasedAt);
            v.Quantity = Field<long>(o, "quantity", ReadLong, v.Quantity);
            v.RevokedAt = Field<string>(o, "revoked_at", ReadString, v.RevokedAt);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WritePurchase(Purchase v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["amount"] = MaybeWriter<long>(WriteLong)(v.Amount);
            j["currency"] = WriteString(v.Currency);
            j["environment"] = WriteString(v.Environment);
            j["expires_at"] = WriteString(v.ExpiresAt);
            j["id"] = WriteString(v.Id);
            j["order_id"] = WriteString(v.OrderId);
            j["product_id"] = WriteString(v.ProductId);
            j["provider"] = WriteString(v.Provider);
            j["provider_product_id"] = WriteString(v.ProviderProductId);
            j["provider_transaction_id"] = WriteString(v.ProviderTransactionId);
            j["purchased_at"] = WriteString(v.PurchasedAt);
            j["quantity"] = WriteLong(v.Quantity);
            j["revoked_at"] = WriteString(v.RevokedAt);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadPurchaseValidation(JToken j, out PurchaseValidation value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PurchaseValidation();
            v.Purchase = Field<Purchase>(o, "purchase", ReadPurchase, v.Purchase);
            v.SeenBefore = Field<bool>(o, "seen_before", ReadBool, v.SeenBefore);
            value = v;
            return true;
        }

        public static JToken WritePurchaseValidation(PurchaseValidation v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["purchase"] = WritePurchase(v.Purchase);
            j["seen_before"] = WriteBool(v.SeenBefore);
            return j;
        }

        public static bool ReadPushToken(JToken j, out PushToken value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new PushToken();
            v.DeviceId = Field<string>(o, "device_id", ReadString, v.DeviceId);
            v.DisabledAt = Field<string>(o, "disabled_at", ReadString, v.DisabledAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.InsertedAt = Field<string>(o, "inserted_at", ReadString, v.InsertedAt);
            v.LastUsedAt = Field<string>(o, "last_used_at", ReadString, v.LastUsedAt);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Platform = Field<string>(o, "platform", ReadString, v.Platform);
            v.Provider = Field<string>(o, "provider", ReadString, v.Provider);
            v.Token = Field<string>(o, "token", ReadString, v.Token);
            value = v;
            return true;
        }

        public static JToken WritePushToken(PushToken v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["device_id"] = WriteString(v.DeviceId);
            j["disabled_at"] = WriteString(v.DisabledAt);
            j["id"] = WriteString(v.Id);
            j["inserted_at"] = WriteString(v.InsertedAt);
            j["last_used_at"] = WriteString(v.LastUsedAt);
            j["metadata"] = WriteToken(v.Metadata);
            j["platform"] = WriteString(v.Platform);
            j["provider"] = WriteString(v.Provider);
            j["token"] = WriteString(v.Token);
            return j;
        }

        public static bool ReadQuestObjective(JToken j, out QuestObjective value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new QuestObjective();
            v.Event = Field<string>(o, "event", ReadString, v.Event);
            v.Params = Field<JToken>(o, "params", ReadToken, v.Params);
            v.Target = Field<long>(o, "target", ReadLong, v.Target);
            value = v;
            return true;
        }

        public static JToken WriteQuestObjective(QuestObjective v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["event"] = WriteString(v.Event);
            j["params"] = WriteToken(v.Params);
            j["target"] = WriteLong(v.Target);
            return j;
        }

        public static bool ReadQuestProgress(JToken j, out QuestProgress value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new QuestProgress();
            v.ClaimCount = Field<long>(o, "claim_count", ReadLong, v.ClaimCount);
            v.ClaimedAt = Field<string>(o, "claimed_at", ReadString, v.ClaimedAt);
            v.CompletedAt = Field<string>(o, "completed_at", ReadString, v.CompletedAt);
            v.ObjectiveProgress = Field<Dictionary<string, long>>(o, "objective_progress", MapOf<long>(ReadLong), v.ObjectiveProgress);
            v.PeriodKey = Field<string>(o, "period_key", ReadString, v.PeriodKey);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteQuestProgress(QuestProgress v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["claim_count"] = WriteLong(v.ClaimCount);
            j["claimed_at"] = WriteString(v.ClaimedAt);
            j["completed_at"] = WriteString(v.CompletedAt);
            j["objective_progress"] = MapWriter<long>(WriteLong)(v.ObjectiveProgress);
            j["period_key"] = WriteString(v.PeriodKey);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadQuestReward(JToken j, out QuestReward value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new QuestReward();
            v.Amount = Field<long>(o, "amount", ReadLong, v.Amount);
            v.Code = Field<string>(o, "code", ReadString, v.Code);
            v.Type = Field<string>(o, "type", ReadString, v.Type);
            value = v;
            return true;
        }

        public static JToken WriteQuestReward(QuestReward v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["amount"] = WriteLong(v.Amount);
            j["code"] = WriteString(v.Code);
            j["type"] = WriteString(v.Type);
            return j;
        }

        public static bool ReadQuest(JToken j, out Quest value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Quest();
            v.AutoClaim = Field<bool>(o, "auto_claim", ReadBool, v.AutoClaim);
            v.Category = Field<string>(o, "category", ReadString, v.Category);
            v.Claimable = Field<bool>(o, "claimable", ReadBool, v.Claimable);
            v.CodeOnly = Field<bool>(o, "code_only", ReadBool, v.CodeOnly);
            v.Description = Field<string>(o, "description", ReadString, v.Description);
            v.EndsAt = Field<string>(o, "ends_at", ReadString, v.EndsAt);
            v.GroupKey = Field<string>(o, "group_key", ReadString, v.GroupKey);
            v.GroupSize = Field<long>(o, "group_size", ReadLong, v.GroupSize);
            v.GroupTitle = Field<string>(o, "group_title", ReadString, v.GroupTitle);
            v.Hidden = Field<bool>(o, "hidden", ReadBool, v.Hidden);
            v.IconUrl = Field<string>(o, "icon_url", ReadString, v.IconUrl);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Key = Field<string>(o, "key", ReadString, v.Key);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Objectives = Field<List<QuestObjective>>(o, "objectives", ListOf<QuestObjective>(ReadQuestObjective), v.Objectives);
            v.PrerequisiteQuestKey = Field<string>(o, "prerequisite_quest_key", ReadString, v.PrerequisiteQuestKey);
            v.Progress = Field<QuestProgress>(o, "progress", ReadQuestProgress, v.Progress);
            v.Reset = Field<string>(o, "reset", ReadString, v.Reset);
            v.ResetIntervalDays = Field<long?>(o, "reset_interval_days", Maybe<long>(ReadLong), v.ResetIntervalDays);
            v.Rewards = Field<List<QuestReward>>(o, "rewards", ListOf<QuestReward>(ReadQuestReward), v.Rewards);
            v.SortOrder = Field<long>(o, "sort_order", ReadLong, v.SortOrder);
            v.StartsAt = Field<string>(o, "starts_at", ReadString, v.StartsAt);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            value = v;
            return true;
        }

        public static JToken WriteQuest(Quest v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["auto_claim"] = WriteBool(v.AutoClaim);
            j["category"] = WriteString(v.Category);
            j["claimable"] = WriteBool(v.Claimable);
            j["code_only"] = WriteBool(v.CodeOnly);
            j["description"] = WriteString(v.Description);
            j["ends_at"] = WriteString(v.EndsAt);
            j["group_key"] = WriteString(v.GroupKey);
            j["group_size"] = WriteLong(v.GroupSize);
            j["group_title"] = WriteString(v.GroupTitle);
            j["hidden"] = WriteBool(v.Hidden);
            j["icon_url"] = WriteString(v.IconUrl);
            j["id"] = WriteString(v.Id);
            j["key"] = WriteString(v.Key);
            j["metadata"] = WriteToken(v.Metadata);
            j["objectives"] = ListWriter<QuestObjective>(WriteQuestObjective)(v.Objectives);
            j["prerequisite_quest_key"] = WriteString(v.PrerequisiteQuestKey);
            j["progress"] = WriteQuestProgress(v.Progress);
            j["reset"] = WriteString(v.Reset);
            j["reset_interval_days"] = MaybeWriter<long>(WriteLong)(v.ResetIntervalDays);
            j["rewards"] = ListWriter<QuestReward>(WriteQuestReward)(v.Rewards);
            j["sort_order"] = WriteLong(v.SortOrder);
            j["starts_at"] = WriteString(v.StartsAt);
            j["title"] = WriteString(v.Title);
            return j;
        }

        public static bool ReadQuestClaim(JToken j, out QuestClaim value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new QuestClaim();
            v.Progress = Field<QuestProgress>(o, "progress", ReadQuestProgress, v.Progress);
            v.Rewards = Field<List<QuestReward>>(o, "rewards", ListOf<QuestReward>(ReadQuestReward), v.Rewards);
            value = v;
            return true;
        }

        public static JToken WriteQuestClaim(QuestClaim v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["progress"] = WriteQuestProgress(v.Progress);
            j["rewards"] = ListWriter<QuestReward>(WriteQuestReward)(v.Rewards);
            return j;
        }

        public static bool ReadQuestStats(JToken j, out QuestStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new QuestStats();
            v.Claimed = Field<long>(o, "claimed", ReadLong, v.Claimed);
            v.Completed = Field<long>(o, "completed", ReadLong, v.Completed);
            v.QuestsTotal = Field<long>(o, "quests_total", ReadLong, v.QuestsTotal);
            value = v;
            return true;
        }

        public static JToken WriteQuestStats(QuestStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["claimed"] = WriteLong(v.Claimed);
            j["completed"] = WriteLong(v.Completed);
            j["quests_total"] = WriteLong(v.QuestsTotal);
            return j;
        }

        public static bool ReadRegistration(JToken j, out Registration value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Registration();
            v.DisplayName = Field<string>(o, "display_name", ReadString, v.DisplayName);
            v.EmailConfirmed = Field<bool>(o, "email_confirmed", ReadBool, v.EmailConfirmed);
            v.UserId = Field<string>(o, "user_id", ReadString, v.UserId);
            v.Username = Field<string>(o, "username", ReadString, v.Username);
            value = v;
            return true;
        }

        public static JToken WriteRegistration(Registration v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["display_name"] = WriteString(v.DisplayName);
            j["email_confirmed"] = WriteBool(v.EmailConfirmed);
            j["user_id"] = WriteString(v.UserId);
            j["username"] = WriteString(v.Username);
            return j;
        }

        public static bool ReadReportKind(JToken j, out ReportKind value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ReportKind();
            v.Key = Field<string>(o, "key", ReadString, v.Key);
            v.MaxAttachmentBytes = Field<long>(o, "max_attachment_bytes", ReadLong, v.MaxAttachmentBytes);
            v.MaxAttachments = Field<long>(o, "max_attachments", ReadLong, v.MaxAttachments);
            v.Topics = Field<List<string>>(o, "topics", ListOf<string>(ReadString), v.Topics);
            value = v;
            return true;
        }

        public static JToken WriteReportKind(ReportKind v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["key"] = WriteString(v.Key);
            j["max_attachment_bytes"] = WriteLong(v.MaxAttachmentBytes);
            j["max_attachments"] = WriteLong(v.MaxAttachments);
            j["topics"] = ListWriter<string>(WriteString)(v.Topics);
            return j;
        }

        public static bool ReadReportKinds(JToken j, out ReportKinds value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ReportKinds();
            v.Kinds = Field<List<ReportKind>>(o, "kinds", ListOf<ReportKind>(ReadReportKind), v.Kinds);
            value = v;
            return true;
        }

        public static JToken WriteReportKinds(ReportKinds v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["kinds"] = ListWriter<ReportKind>(WriteReportKind)(v.Kinds);
            return j;
        }

        public static bool ReadReportReceipt(JToken j, out ReportReceipt value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ReportReceipt();
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Kind = Field<string>(o, "kind", ReadString, v.Kind);
            v.Status = Field<string>(o, "status", ReadString, v.Status);
            value = v;
            return true;
        }

        public static JToken WriteReportReceipt(ReportReceipt v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["id"] = WriteString(v.Id);
            j["kind"] = WriteString(v.Kind);
            j["status"] = WriteString(v.Status);
            return j;
        }

        public static bool ReadReportRequest(JToken j, out ReportRequest value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ReportRequest();
            v.Attachments = Field<List<string>>(o, "attachments", ListOf<string>(ReadString), v.Attachments);
            v.Client = Field<Dictionary<string, string>>(o, "client", MapOf<string>(ReadString), v.Client);
            v.Data = Field<JToken>(o, "data", ReadToken, v.Data);
            v.Description = Field<string>(o, "description", ReadString, v.Description);
            v.Email = Field<string>(o, "email", ReadString, v.Email);
            v.Kind = Field<string>(o, "kind", ReadString, v.Kind);
            v.Locale = Field<string>(o, "locale", ReadString, v.Locale);
            v.Subject = Field<JToken>(o, "subject", ReadToken, v.Subject);
            v.Topic = Field<string>(o, "topic", ReadString, v.Topic);
            value = v;
            return true;
        }

        public static JToken WriteReportRequest(ReportRequest v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["attachments"] = ListWriter<string>(WriteString)(v.Attachments);
            j["client"] = MapWriter<string>(WriteString)(v.Client);
            j["data"] = WriteToken(v.Data);
            j["description"] = WriteString(v.Description);
            j["email"] = WriteString(v.Email);
            j["kind"] = WriteString(v.Kind);
            j["locale"] = WriteString(v.Locale);
            j["subject"] = WriteToken(v.Subject);
            j["topic"] = WriteString(v.Topic);
            return j;
        }

        public static bool ReadSignalingStats(JToken j, out SignalingStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new SignalingStats();
            v.PeersConnected = Field<long>(o, "peers_connected", ReadLong, v.PeersConnected);
            v.RoomsActive = Field<long>(o, "rooms_active", ReadLong, v.RoomsActive);
            v.RoomsEnabled = Field<long>(o, "rooms_enabled", ReadLong, v.RoomsEnabled);
            value = v;
            return true;
        }

        public static JToken WriteSignalingStats(SignalingStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["peers_connected"] = WriteLong(v.PeersConnected);
            j["rooms_active"] = WriteLong(v.RoomsActive);
            j["rooms_enabled"] = WriteLong(v.RoomsEnabled);
            return j;
        }

        public static bool ReadTournamentMatchCounts(JToken j, out TournamentMatchCounts value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentMatchCounts();
            v.Open = Field<long>(o, "open", ReadLong, v.Open);
            v.Overdue = Field<long>(o, "overdue", ReadLong, v.Overdue);
            v.Total = Field<long>(o, "total", ReadLong, v.Total);
            value = v;
            return true;
        }

        public static JToken WriteTournamentMatchCounts(TournamentMatchCounts v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["open"] = WriteLong(v.Open);
            j["overdue"] = WriteLong(v.Overdue);
            j["total"] = WriteLong(v.Total);
            return j;
        }

        public static bool ReadTournamentStats(JToken j, out TournamentStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentStats();
            v.Entries = Field<Dictionary<string, long>>(o, "entries", MapOf<long>(ReadLong), v.Entries);
            v.Matches = Field<TournamentMatchCounts>(o, "matches", ReadTournamentMatchCounts, v.Matches);
            v.Tournaments = Field<Dictionary<string, long>>(o, "tournaments", MapOf<long>(ReadLong), v.Tournaments);
            value = v;
            return true;
        }

        public static JToken WriteTournamentStats(TournamentStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["entries"] = MapWriter<long>(WriteLong)(v.Entries);
            j["matches"] = WriteTournamentMatchCounts(v.Matches);
            j["tournaments"] = MapWriter<long>(WriteLong)(v.Tournaments);
            return j;
        }

        public static bool ReadServerStats(JToken j, out ServerStats value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ServerStats();
            v.Activity = Field<ActivityStats>(o, "activity", ReadActivityStats, v.Activity);
            v.Lobbies = Field<LobbyStats>(o, "lobbies", ReadLobbyStats, v.Lobbies);
            v.Matchmaking = Field<MatchmakingStats>(o, "matchmaking", ReadMatchmakingStats, v.Matchmaking);
            v.Parties = Field<PartyStats>(o, "parties", ReadPartyStats, v.Parties);
            v.Players = Field<PlayerStats>(o, "players", ReadPlayerStats, v.Players);
            v.Quests = Field<QuestStats>(o, "quests", ReadQuestStats, v.Quests);
            v.Signaling = Field<SignalingStats>(o, "signaling", ReadSignalingStats, v.Signaling);
            v.Tournaments = Field<TournamentStats>(o, "tournaments", ReadTournamentStats, v.Tournaments);
            value = v;
            return true;
        }

        public static JToken WriteServerStats(ServerStats v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["activity"] = WriteActivityStats(v.Activity);
            j["lobbies"] = WriteLobbyStats(v.Lobbies);
            j["matchmaking"] = WriteMatchmakingStats(v.Matchmaking);
            j["parties"] = WritePartyStats(v.Parties);
            j["players"] = WritePlayerStats(v.Players);
            j["quests"] = WriteQuestStats(v.Quests);
            j["signaling"] = WriteSignalingStats(v.Signaling);
            j["tournaments"] = WriteTournamentStats(v.Tournaments);
            return j;
        }

        public static bool ReadServerTime(JToken j, out ServerTime value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new ServerTime();
            v.ServerNow = Field<long>(o, "server_now", ReadLong, v.ServerNow);
            value = v;
            return true;
        }

        public static JToken WriteServerTime(ServerTime v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["server_now"] = WriteLong(v.ServerNow);
            return j;
        }

        public static bool ReadSteamCheckout(JToken j, out SteamCheckout value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new SteamCheckout();
            v.ProviderTransactionId = Field<string>(o, "provider_transaction_id", ReadString, v.ProviderTransactionId);
            v.Purchase = Field<Purchase>(o, "purchase", ReadPurchase, v.Purchase);
            v.SteamUrl = Field<string>(o, "steam_url", ReadString, v.SteamUrl);
            value = v;
            return true;
        }

        public static JToken WriteSteamCheckout(SteamCheckout v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["provider_transaction_id"] = WriteString(v.ProviderTransactionId);
            j["purchase"] = WritePurchase(v.Purchase);
            j["steam_url"] = WriteString(v.SteamUrl);
            return j;
        }

        public static bool ReadStripeCheckout(JToken j, out StripeCheckout value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new StripeCheckout();
            v.CheckoutUrl = Field<string>(o, "checkout_url", ReadString, v.CheckoutUrl);
            v.ProviderSessionId = Field<string>(o, "provider_session_id", ReadString, v.ProviderSessionId);
            v.Purchase = Field<Purchase>(o, "purchase", ReadPurchase, v.Purchase);
            value = v;
            return true;
        }

        public static JToken WriteStripeCheckout(StripeCheckout v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["checkout_url"] = WriteString(v.CheckoutUrl);
            j["provider_session_id"] = WriteString(v.ProviderSessionId);
            j["purchase"] = WritePurchase(v.Purchase);
            return j;
        }

        public static bool ReadTournamentEntry(JToken j, out TournamentEntry value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentEntry();
            v.BracketIndex = Field<long?>(o, "bracket_index", Maybe<long>(ReadLong), v.BracketIndex);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.LeaderId = Field<string>(o, "leader_id", ReadString, v.LeaderId);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.Seed = Field<long?>(o, "seed", Maybe<long>(ReadLong), v.Seed);
            v.State = Field<string>(o, "state", ReadString, v.State);
            v.Wins = Field<long>(o, "wins", ReadLong, v.Wins);
            value = v;
            return true;
        }

        public static JToken WriteTournamentEntry(TournamentEntry v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["bracket_index"] = MaybeWriter<long>(WriteLong)(v.BracketIndex);
            j["id"] = WriteString(v.Id);
            j["leader_id"] = WriteString(v.LeaderId);
            j["metadata"] = WriteToken(v.Metadata);
            j["seed"] = MaybeWriter<long>(WriteLong)(v.Seed);
            j["state"] = WriteString(v.State);
            j["wins"] = WriteLong(v.Wins);
            return j;
        }

        public static bool ReadTournament(JToken j, out Tournament value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new Tournament();
            v.BracketSize = Field<long>(o, "bracket_size", ReadLong, v.BracketSize);
            v.Description = Field<string>(o, "description", ReadString, v.Description);
            v.EndsAt = Field<string>(o, "ends_at", ReadString, v.EndsAt);
            v.EntryCount = Field<long>(o, "entry_count", ReadLong, v.EntryCount);
            v.IconUrl = Field<string>(o, "icon_url", ReadString, v.IconUrl);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.MaxEntries = Field<long?>(o, "max_entries", Maybe<long>(ReadLong), v.MaxEntries);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.MyEntry = Field<TournamentEntry>(o, "my_entry", ReadTournamentEntry, v.MyEntry);
            v.Recur = Field<string>(o, "recur", ReadString, v.Recur);
            v.RegistrationOpensAt = Field<string>(o, "registration_opens_at", ReadString, v.RegistrationOpensAt);
            v.RoundWindowSec = Field<long>(o, "round_window_sec", ReadLong, v.RoundWindowSec);
            v.Slug = Field<string>(o, "slug", ReadString, v.Slug);
            v.StartsAt = Field<string>(o, "starts_at", ReadString, v.StartsAt);
            v.State = Field<string>(o, "state", ReadString, v.State);
            v.TeamSize = Field<long>(o, "team_size", ReadLong, v.TeamSize);
            v.Title = Field<string>(o, "title", ReadString, v.Title);
            value = v;
            return true;
        }

        public static JToken WriteTournament(Tournament v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["bracket_size"] = WriteLong(v.BracketSize);
            j["description"] = WriteString(v.Description);
            j["ends_at"] = WriteString(v.EndsAt);
            j["entry_count"] = WriteLong(v.EntryCount);
            j["icon_url"] = WriteString(v.IconUrl);
            j["id"] = WriteString(v.Id);
            j["max_entries"] = MaybeWriter<long>(WriteLong)(v.MaxEntries);
            j["metadata"] = WriteToken(v.Metadata);
            j["my_entry"] = WriteTournamentEntry(v.MyEntry);
            j["recur"] = WriteString(v.Recur);
            j["registration_opens_at"] = WriteString(v.RegistrationOpensAt);
            j["round_window_sec"] = WriteLong(v.RoundWindowSec);
            j["slug"] = WriteString(v.Slug);
            j["starts_at"] = WriteString(v.StartsAt);
            j["state"] = WriteString(v.State);
            j["team_size"] = WriteLong(v.TeamSize);
            j["title"] = WriteString(v.Title);
            return j;
        }

        public static bool ReadTournamentMatch(JToken j, out TournamentMatch value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentMatch();
            v.AEntryId = Field<string>(o, "a_entry_id", ReadString, v.AEntryId);
            v.ALeaderId = Field<string>(o, "a_leader_id", ReadString, v.ALeaderId);
            v.BEntryId = Field<string>(o, "b_entry_id", ReadString, v.BEntryId);
            v.BLeaderId = Field<string>(o, "b_leader_id", ReadString, v.BLeaderId);
            v.BracketIndex = Field<long>(o, "bracket_index", ReadLong, v.BracketIndex);
            v.DeadlineAt = Field<string>(o, "deadline_at", ReadString, v.DeadlineAt);
            v.Id = Field<string>(o, "id", ReadString, v.Id);
            v.Metadata = Field<JToken>(o, "metadata", ReadToken, v.Metadata);
            v.ResolvedAt = Field<string>(o, "resolved_at", ReadString, v.ResolvedAt);
            v.Round = Field<long>(o, "round", ReadLong, v.Round);
            v.Slot = Field<long>(o, "slot", ReadLong, v.Slot);
            v.WinnerEntryId = Field<string>(o, "winner_entry_id", ReadString, v.WinnerEntryId);
            value = v;
            return true;
        }

        public static JToken WriteTournamentMatch(TournamentMatch v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["a_entry_id"] = WriteString(v.AEntryId);
            j["a_leader_id"] = WriteString(v.ALeaderId);
            j["b_entry_id"] = WriteString(v.BEntryId);
            j["b_leader_id"] = WriteString(v.BLeaderId);
            j["bracket_index"] = WriteLong(v.BracketIndex);
            j["deadline_at"] = WriteString(v.DeadlineAt);
            j["id"] = WriteString(v.Id);
            j["metadata"] = WriteToken(v.Metadata);
            j["resolved_at"] = WriteString(v.ResolvedAt);
            j["round"] = WriteLong(v.Round);
            j["slot"] = WriteLong(v.Slot);
            j["winner_entry_id"] = WriteString(v.WinnerEntryId);
            return j;
        }

        public static bool ReadTournamentBracket(JToken j, out TournamentBracket value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentBracket();
            v.Entries = Field<List<TournamentEntry>>(o, "entries", ListOf<TournamentEntry>(ReadTournamentEntry), v.Entries);
            v.Index = Field<long>(o, "index", ReadLong, v.Index);
            v.Matches = Field<List<TournamentMatch>>(o, "matches", ListOf<TournamentMatch>(ReadTournamentMatch), v.Matches);
            v.Size = Field<long>(o, "size", ReadLong, v.Size);
            value = v;
            return true;
        }

        public static JToken WriteTournamentBracket(TournamentBracket v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["entries"] = ListWriter<TournamentEntry>(WriteTournamentEntry)(v.Entries);
            j["index"] = WriteLong(v.Index);
            j["matches"] = ListWriter<TournamentMatch>(WriteTournamentMatch)(v.Matches);
            j["size"] = WriteLong(v.Size);
            return j;
        }

        public static bool ReadTournamentPlacement(JToken j, out TournamentPlacement value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentPlacement();
            v.BracketIndex = Field<long?>(o, "bracket_index", Maybe<long>(ReadLong), v.BracketIndex);
            v.EntryId = Field<string>(o, "entry_id", ReadString, v.EntryId);
            v.LeaderId = Field<string>(o, "leader_id", ReadString, v.LeaderId);
            v.Placement = Field<long>(o, "placement", ReadLong, v.Placement);
            v.State = Field<string>(o, "state", ReadString, v.State);
            v.Wins = Field<long>(o, "wins", ReadLong, v.Wins);
            value = v;
            return true;
        }

        public static JToken WriteTournamentPlacement(TournamentPlacement v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["bracket_index"] = MaybeWriter<long>(WriteLong)(v.BracketIndex);
            j["entry_id"] = WriteString(v.EntryId);
            j["leader_id"] = WriteString(v.LeaderId);
            j["placement"] = WriteLong(v.Placement);
            j["state"] = WriteString(v.State);
            j["wins"] = WriteLong(v.Wins);
            return j;
        }

        public static bool ReadTournamentStandings(JToken j, out TournamentStandings value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new TournamentStandings();
            v.Champions = Field<List<TournamentEntry>>(o, "champions", ListOf<TournamentEntry>(ReadTournamentEntry), v.Champions);
            v.Placements = Field<List<TournamentPlacement>>(o, "placements", ListOf<TournamentPlacement>(ReadTournamentPlacement), v.Placements);
            value = v;
            return true;
        }

        public static JToken WriteTournamentStandings(TournamentStandings v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["champions"] = ListWriter<TournamentEntry>(WriteTournamentEntry)(v.Champions);
            j["placements"] = ListWriter<TournamentPlacement>(WriteTournamentPlacement)(v.Placements);
            return j;
        }

        public static bool ReadUploadTicket(JToken j, out UploadTicket value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            var v = new UploadTicket();
            v.ExpiresIn = Field<long>(o, "expires_in", ReadLong, v.ExpiresIn);
            v.Headers = Field<Dictionary<string, string>>(o, "headers", MapOf<string>(ReadString), v.Headers);
            v.Key = Field<string>(o, "key", ReadString, v.Key);
            v.Method = Field<string>(o, "method", ReadString, v.Method);
            v.Token = Field<string>(o, "token", ReadString, v.Token);
            v.Url = Field<string>(o, "url", ReadString, v.Url);
            value = v;
            return true;
        }

        public static JToken WriteUploadTicket(UploadTicket v)
        {
            if (v == null) return JValue.CreateNull();
            var j = new JObject();
            j["expires_in"] = WriteLong(v.ExpiresIn);
            j["headers"] = MapWriter<string>(WriteString)(v.Headers);
            j["key"] = WriteString(v.Key);
            j["method"] = WriteString(v.Method);
            j["token"] = WriteString(v.Token);
            j["url"] = WriteString(v.Url);
            return j;
        }

        public static bool ReadWalletBalances(JToken j, out WalletBalances value)
        {
            value = null;
            var o = j as JObject;
            if (o == null) return false;
            value = new WalletBalances();
            Fill<long>(o, value, ReadLong);
            return true;
        }

        public static JToken WriteWalletBalances(WalletBalances v)
        {
            return MapWriter<long>(WriteLong)(v);
        }

        /// <summary>What `Response.As` and `Response.Page` look a type up in.</summary>
        internal static readonly Dictionary<Type, Func<JToken, object>> Readers =
            new Dictionary<Type, Func<JToken, object>>
        {
            [typeof(string)] = j => { string v; return ReadString(j, out v) ? v : null; },
            [typeof(List<string>)] = j => { List<string> v; return ListOf<string>(ReadString)(j, out v) ? v : null; },
            [typeof(Dictionary<string, string>)] = j => { Dictionary<string, string> v; return MapOf<string>(ReadString)(j, out v) ? v : null; },
            [typeof(long)] = j => { long v; return ReadLong(j, out v) ? (object)v : null; },
            [typeof(List<long>)] = j => { List<long> v; return ListOf<long>(ReadLong)(j, out v) ? v : null; },
            [typeof(Dictionary<string, long>)] = j => { Dictionary<string, long> v; return MapOf<long>(ReadLong)(j, out v) ? v : null; },
            [typeof(double)] = j => { double v; return ReadDouble(j, out v) ? (object)v : null; },
            [typeof(List<double>)] = j => { List<double> v; return ListOf<double>(ReadDouble)(j, out v) ? v : null; },
            [typeof(Dictionary<string, double>)] = j => { Dictionary<string, double> v; return MapOf<double>(ReadDouble)(j, out v) ? v : null; },
            [typeof(bool)] = j => { bool v; return ReadBool(j, out v) ? (object)v : null; },
            [typeof(List<bool>)] = j => { List<bool> v; return ListOf<bool>(ReadBool)(j, out v) ? v : null; },
            [typeof(Dictionary<string, bool>)] = j => { Dictionary<string, bool> v; return MapOf<bool>(ReadBool)(j, out v) ? v : null; },
            [typeof(JToken)] = j => { JToken v; return ReadToken(j, out v) ? v : null; },
            [typeof(List<JToken>)] = j => { List<JToken> v; return ListOf<JToken>(ReadToken)(j, out v) ? v : null; },
            [typeof(Dictionary<string, JToken>)] = j => { Dictionary<string, JToken> v; return MapOf<JToken>(ReadToken)(j, out v) ? v : null; },
            [typeof(long?)] = j => { long? v; return Maybe<long>(ReadLong)(j, out v) ? (object)v : null; },
            [typeof(double?)] = j => { double? v; return Maybe<double>(ReadDouble)(j, out v) ? (object)v : null; },
            [typeof(bool?)] = j => { bool? v; return Maybe<bool>(ReadBool)(j, out v) ? (object)v : null; },
            [typeof(AccountBan)] = j => { AccountBan v; return ReadAccountBan(j, out v) ? v : null; },
            [typeof(List<AccountBan>)] = j => { List<AccountBan> v; return ListOf<AccountBan>(ReadAccountBan)(j, out v) ? v : null; },
            [typeof(ActivityStats)] = j => { ActivityStats v; return ReadActivityStats(j, out v) ? v : null; },
            [typeof(List<ActivityStats>)] = j => { List<ActivityStats> v; return ListOf<ActivityStats>(ReadActivityStats)(j, out v) ? v : null; },
            [typeof(UserBrief)] = j => { UserBrief v; return ReadUserBrief(j, out v) ? v : null; },
            [typeof(List<UserBrief>)] = j => { List<UserBrief> v; return ListOf<UserBrief>(ReadUserBrief)(j, out v) ? v : null; },
            [typeof(BlockedFriendship)] = j => { BlockedFriendship v; return ReadBlockedFriendship(j, out v) ? v : null; },
            [typeof(List<BlockedFriendship>)] = j => { List<BlockedFriendship> v; return ListOf<BlockedFriendship>(ReadBlockedFriendship)(j, out v) ? v : null; },
            [typeof(CancelledCount)] = j => { CancelledCount v; return ReadCancelledCount(j, out v) ? v : null; },
            [typeof(List<CancelledCount>)] = j => { List<CancelledCount> v; return ListOf<CancelledCount>(ReadCancelledCount)(j, out v) ? v : null; },
            [typeof(ChatMessage)] = j => { ChatMessage v; return ReadChatMessage(j, out v) ? v : null; },
            [typeof(List<ChatMessage>)] = j => { List<ChatMessage> v; return ListOf<ChatMessage>(ReadChatMessage)(j, out v) ? v : null; },
            [typeof(ChatMuteRecord)] = j => { ChatMuteRecord v; return ReadChatMuteRecord(j, out v) ? v : null; },
            [typeof(List<ChatMuteRecord>)] = j => { List<ChatMuteRecord> v; return ListOf<ChatMuteRecord>(ReadChatMuteRecord)(j, out v) ? v : null; },
            [typeof(ChatReadCursor)] = j => { ChatReadCursor v; return ReadChatReadCursor(j, out v) ? v : null; },
            [typeof(List<ChatReadCursor>)] = j => { List<ChatReadCursor> v; return ListOf<ChatReadCursor>(ReadChatReadCursor)(j, out v) ? v : null; },
            [typeof(ChatUnread)] = j => { ChatUnread v; return ReadChatUnread(j, out v) ? v : null; },
            [typeof(List<ChatUnread>)] = j => { List<ChatUnread> v; return ListOf<ChatUnread>(ReadChatUnread)(j, out v) ? v : null; },
            [typeof(ClientLogEntry)] = j => { ClientLogEntry v; return ReadClientLogEntry(j, out v) ? v : null; },
            [typeof(List<ClientLogEntry>)] = j => { List<ClientLogEntry> v; return ListOf<ClientLogEntry>(ReadClientLogEntry)(j, out v) ? v : null; },
            [typeof(ClientLogSession)] = j => { ClientLogSession v; return ReadClientLogSession(j, out v) ? v : null; },
            [typeof(List<ClientLogSession>)] = j => { List<ClientLogSession> v; return ListOf<ClientLogSession>(ReadClientLogSession)(j, out v) ? v : null; },
            [typeof(ClientLogBatch)] = j => { ClientLogBatch v; return ReadClientLogBatch(j, out v) ? v : null; },
            [typeof(List<ClientLogBatch>)] = j => { List<ClientLogBatch> v; return ListOf<ClientLogBatch>(ReadClientLogBatch)(j, out v) ? v : null; },
            [typeof(ClientLogPolicy)] = j => { ClientLogPolicy v; return ReadClientLogPolicy(j, out v) ? v : null; },
            [typeof(List<ClientLogPolicy>)] = j => { List<ClientLogPolicy> v; return ListOf<ClientLogPolicy>(ReadClientLogPolicy)(j, out v) ? v : null; },
            [typeof(ClientLogResult)] = j => { ClientLogResult v; return ReadClientLogResult(j, out v) ? v : null; },
            [typeof(List<ClientLogResult>)] = j => { List<ClientLogResult> v; return ListOf<ClientLogResult>(ReadClientLogResult)(j, out v) ? v : null; },
            [typeof(LinkedProviders)] = j => { LinkedProviders v; return ReadLinkedProviders(j, out v) ? v : null; },
            [typeof(List<LinkedProviders>)] = j => { List<LinkedProviders> v; return ListOf<LinkedProviders>(ReadLinkedProviders)(j, out v) ? v : null; },
            [typeof(CurrentUser)] = j => { CurrentUser v; return ReadCurrentUser(j, out v) ? v : null; },
            [typeof(List<CurrentUser>)] = j => { List<CurrentUser> v; return ListOf<CurrentUser>(ReadCurrentUser)(j, out v) ? v : null; },
            [typeof(DeletedCount)] = j => { DeletedCount v; return ReadDeletedCount(j, out v) ? v : null; },
            [typeof(List<DeletedCount>)] = j => { List<DeletedCount> v; return ListOf<DeletedCount>(ReadDeletedCount)(j, out v) ? v : null; },
            [typeof(Entitlement)] = j => { Entitlement v; return ReadEntitlement(j, out v) ? v : null; },
            [typeof(List<Entitlement>)] = j => { List<Entitlement> v; return ListOf<Entitlement>(ReadEntitlement)(j, out v) ? v : null; },
            [typeof(ErrorResponse)] = j => { ErrorResponse v; return ReadErrorResponse(j, out v) ? v : null; },
            [typeof(List<ErrorResponse>)] = j => { List<ErrorResponse> v; return ListOf<ErrorResponse>(ReadErrorResponse)(j, out v) ? v : null; },
            [typeof(Friend)] = j => { Friend v; return ReadFriend(j, out v) ? v : null; },
            [typeof(List<Friend>)] = j => { List<Friend> v; return ListOf<Friend>(ReadFriend)(j, out v) ? v : null; },
            [typeof(FriendRequest)] = j => { FriendRequest v; return ReadFriendRequest(j, out v) ? v : null; },
            [typeof(List<FriendRequest>)] = j => { List<FriendRequest> v; return ListOf<FriendRequest>(ReadFriendRequest)(j, out v) ? v : null; },
            [typeof(FriendRequestLists)] = j => { FriendRequestLists v; return ReadFriendRequestLists(j, out v) ? v : null; },
            [typeof(List<FriendRequestLists>)] = j => { List<FriendRequestLists> v; return ListOf<FriendRequestLists>(ReadFriendRequestLists)(j, out v) ? v : null; },
            [typeof(PageMeta)] = j => { PageMeta v; return ReadPageMeta(j, out v) ? v : null; },
            [typeof(List<PageMeta>)] = j => { List<PageMeta> v; return ListOf<PageMeta>(ReadPageMeta)(j, out v) ? v : null; },
            [typeof(FriendRequestMeta)] = j => { FriendRequestMeta v; return ReadFriendRequestMeta(j, out v) ? v : null; },
            [typeof(List<FriendRequestMeta>)] = j => { List<FriendRequestMeta> v; return ListOf<FriendRequestMeta>(ReadFriendRequestMeta)(j, out v) ? v : null; },
            [typeof(Group)] = j => { Group v; return ReadGroup(j, out v) ? v : null; },
            [typeof(List<Group>)] = j => { List<Group> v; return ListOf<Group>(ReadGroup)(j, out v) ? v : null; },
            [typeof(GroupInvite)] = j => { GroupInvite v; return ReadGroupInvite(j, out v) ? v : null; },
            [typeof(List<GroupInvite>)] = j => { List<GroupInvite> v; return ListOf<GroupInvite>(ReadGroupInvite)(j, out v) ? v : null; },
            [typeof(GroupInviteLink)] = j => { GroupInviteLink v; return ReadGroupInviteLink(j, out v) ? v : null; },
            [typeof(List<GroupInviteLink>)] = j => { List<GroupInviteLink> v; return ListOf<GroupInviteLink>(ReadGroupInviteLink)(j, out v) ? v : null; },
            [typeof(GroupInviteLinkPreview)] = j => { GroupInviteLinkPreview v; return ReadGroupInviteLinkPreview(j, out v) ? v : null; },
            [typeof(List<GroupInviteLinkPreview>)] = j => { List<GroupInviteLinkPreview> v; return ListOf<GroupInviteLinkPreview>(ReadGroupInviteLinkPreview)(j, out v) ? v : null; },
            [typeof(GroupInviteOutcome)] = j => { GroupInviteOutcome v; return ReadGroupInviteOutcome(j, out v) ? v : null; },
            [typeof(List<GroupInviteOutcome>)] = j => { List<GroupInviteOutcome> v; return ListOf<GroupInviteOutcome>(ReadGroupInviteOutcome)(j, out v) ? v : null; },
            [typeof(GroupJoinRequest)] = j => { GroupJoinRequest v; return ReadGroupJoinRequest(j, out v) ? v : null; },
            [typeof(List<GroupJoinRequest>)] = j => { List<GroupJoinRequest> v; return ListOf<GroupJoinRequest>(ReadGroupJoinRequest)(j, out v) ? v : null; },
            [typeof(GroupMember)] = j => { GroupMember v; return ReadGroupMember(j, out v) ? v : null; },
            [typeof(List<GroupMember>)] = j => { List<GroupMember> v; return ListOf<GroupMember>(ReadGroupMember)(j, out v) ? v : null; },
            [typeof(Health)] = j => { Health v; return ReadHealth(j, out v) ? v : null; },
            [typeof(List<Health>)] = j => { List<Health> v; return ListOf<Health>(ReadHealth)(j, out v) ? v : null; },
            [typeof(HookSignature)] = j => { HookSignature v; return ReadHookSignature(j, out v) ? v : null; },
            [typeof(List<HookSignature>)] = j => { List<HookSignature> v; return ListOf<HookSignature>(ReadHookSignature)(j, out v) ? v : null; },
            [typeof(HookFunction)] = j => { HookFunction v; return ReadHookFunction(j, out v) ? v : null; },
            [typeof(List<HookFunction>)] = j => { List<HookFunction> v; return ListOf<HookFunction>(ReadHookFunction)(j, out v) ? v : null; },
            [typeof(Inventory)] = j => { Inventory v; return ReadInventory(j, out v) ? v : null; },
            [typeof(List<Inventory>)] = j => { List<Inventory> v; return ListOf<Inventory>(ReadInventory)(j, out v) ? v : null; },
            [typeof(KvEntry)] = j => { KvEntry v; return ReadKvEntry(j, out v) ? v : null; },
            [typeof(List<KvEntry>)] = j => { List<KvEntry> v; return ListOf<KvEntry>(ReadKvEntry)(j, out v) ? v : null; },
            [typeof(Leaderboard)] = j => { Leaderboard v; return ReadLeaderboard(j, out v) ? v : null; },
            [typeof(List<Leaderboard>)] = j => { List<Leaderboard> v; return ListOf<Leaderboard>(ReadLeaderboard)(j, out v) ? v : null; },
            [typeof(LeaderboardKeys)] = j => { LeaderboardKeys v; return ReadLeaderboardKeys(j, out v) ? v : null; },
            [typeof(List<LeaderboardKeys>)] = j => { List<LeaderboardKeys> v; return ListOf<LeaderboardKeys>(ReadLeaderboardKeys)(j, out v) ? v : null; },
            [typeof(LeaderboardRecord)] = j => { LeaderboardRecord v; return ReadLeaderboardRecord(j, out v) ? v : null; },
            [typeof(List<LeaderboardRecord>)] = j => { List<LeaderboardRecord> v; return ListOf<LeaderboardRecord>(ReadLeaderboardRecord)(j, out v) ? v : null; },
            [typeof(LeaderboardsBySlug)] = j => { LeaderboardsBySlug v; return ReadLeaderboardsBySlug(j, out v) ? v : null; },
            [typeof(List<LeaderboardsBySlug>)] = j => { List<LeaderboardsBySlug> v; return ListOf<LeaderboardsBySlug>(ReadLeaderboardsBySlug)(j, out v) ? v : null; },
            [typeof(Dictionary<string, Leaderboard>)] = j => { Dictionary<string, Leaderboard> v; return MapOf<Leaderboard>(ReadLeaderboard)(j, out v) ? v : null; },
            [typeof(LedgerEntry)] = j => { LedgerEntry v; return ReadLedgerEntry(j, out v) ? v : null; },
            [typeof(List<LedgerEntry>)] = j => { List<LedgerEntry> v; return ListOf<LedgerEntry>(ReadLedgerEntry)(j, out v) ? v : null; },
            [typeof(Lobby)] = j => { Lobby v; return ReadLobby(j, out v) ? v : null; },
            [typeof(List<Lobby>)] = j => { List<Lobby> v; return ListOf<Lobby>(ReadLobby)(j, out v) ? v : null; },
            [typeof(LobbyStats)] = j => { LobbyStats v; return ReadLobbyStats(j, out v) ? v : null; },
            [typeof(List<LobbyStats>)] = j => { List<LobbyStats> v; return ListOf<LobbyStats>(ReadLobbyStats)(j, out v) ? v : null; },
            [typeof(MatchmakingQueue)] = j => { MatchmakingQueue v; return ReadMatchmakingQueue(j, out v) ? v : null; },
            [typeof(List<MatchmakingQueue>)] = j => { List<MatchmakingQueue> v; return ListOf<MatchmakingQueue>(ReadMatchmakingQueue)(j, out v) ? v : null; },
            [typeof(MatchmakingStats)] = j => { MatchmakingStats v; return ReadMatchmakingStats(j, out v) ? v : null; },
            [typeof(List<MatchmakingStats>)] = j => { List<MatchmakingStats> v; return ListOf<MatchmakingStats>(ReadMatchmakingStats)(j, out v) ? v : null; },
            [typeof(MatchmakingTicket)] = j => { MatchmakingTicket v; return ReadMatchmakingTicket(j, out v) ? v : null; },
            [typeof(List<MatchmakingTicket>)] = j => { List<MatchmakingTicket> v; return ListOf<MatchmakingTicket>(ReadMatchmakingTicket)(j, out v) ? v : null; },
            [typeof(ReadyCheckParticipant)] = j => { ReadyCheckParticipant v; return ReadReadyCheckParticipant(j, out v) ? v : null; },
            [typeof(List<ReadyCheckParticipant>)] = j => { List<ReadyCheckParticipant> v; return ListOf<ReadyCheckParticipant>(ReadReadyCheckParticipant)(j, out v) ? v : null; },
            [typeof(ReadyCheckState)] = j => { ReadyCheckState v; return ReadReadyCheckState(j, out v) ? v : null; },
            [typeof(List<ReadyCheckState>)] = j => { List<ReadyCheckState> v; return ListOf<ReadyCheckState>(ReadReadyCheckState)(j, out v) ? v : null; },
            [typeof(MyReadyChecks)] = j => { MyReadyChecks v; return ReadMyReadyChecks(j, out v) ? v : null; },
            [typeof(List<MyReadyChecks>)] = j => { List<MyReadyChecks> v; return ListOf<MyReadyChecks>(ReadMyReadyChecks)(j, out v) ? v : null; },
            [typeof(Notification)] = j => { Notification v; return ReadNotification(j, out v) ? v : null; },
            [typeof(List<Notification>)] = j => { List<Notification> v; return ListOf<Notification>(ReadNotification)(j, out v) ? v : null; },
            [typeof(OAuthAuthorization)] = j => { OAuthAuthorization v; return ReadOAuthAuthorization(j, out v) ? v : null; },
            [typeof(List<OAuthAuthorization>)] = j => { List<OAuthAuthorization> v; return ListOf<OAuthAuthorization>(ReadOAuthAuthorization)(j, out v) ? v : null; },
            [typeof(Session)] = j => { Session v; return ReadSession(j, out v) ? v : null; },
            [typeof(List<Session>)] = j => { List<Session> v; return ListOf<Session>(ReadSession)(j, out v) ? v : null; },
            [typeof(OAuthSessionStatus)] = j => { OAuthSessionStatus v; return ReadOAuthSessionStatus(j, out v) ? v : null; },
            [typeof(List<OAuthSessionStatus>)] = j => { List<OAuthSessionStatus> v; return ListOf<OAuthSessionStatus>(ReadOAuthSessionStatus)(j, out v) ? v : null; },
            [typeof(OkResponse)] = j => { OkResponse v; return ReadOkResponse(j, out v) ? v : null; },
            [typeof(List<OkResponse>)] = j => { List<OkResponse> v; return ListOf<OkResponse>(ReadOkResponse)(j, out v) ? v : null; },
            [typeof(Party)] = j => { Party v; return ReadParty(j, out v) ? v : null; },
            [typeof(List<Party>)] = j => { List<Party> v; return ListOf<Party>(ReadParty)(j, out v) ? v : null; },
            [typeof(PartyInvite)] = j => { PartyInvite v; return ReadPartyInvite(j, out v) ? v : null; },
            [typeof(List<PartyInvite>)] = j => { List<PartyInvite> v; return ListOf<PartyInvite>(ReadPartyInvite)(j, out v) ? v : null; },
            [typeof(PartyStats)] = j => { PartyStats v; return ReadPartyStats(j, out v) ? v : null; },
            [typeof(List<PartyStats>)] = j => { List<PartyStats> v; return ListOf<PartyStats>(ReadPartyStats)(j, out v) ? v : null; },
            [typeof(PaymentProduct)] = j => { PaymentProduct v; return ReadPaymentProduct(j, out v) ? v : null; },
            [typeof(List<PaymentProduct>)] = j => { List<PaymentProduct> v; return ListOf<PaymentProduct>(ReadPaymentProduct)(j, out v) ? v : null; },
            [typeof(PaymentCatalogEntry)] = j => { PaymentCatalogEntry v; return ReadPaymentCatalogEntry(j, out v) ? v : null; },
            [typeof(List<PaymentCatalogEntry>)] = j => { List<PaymentCatalogEntry> v; return ListOf<PaymentCatalogEntry>(ReadPaymentCatalogEntry)(j, out v) ? v : null; },
            [typeof(PaymentWebhookReceipt)] = j => { PaymentWebhookReceipt v; return ReadPaymentWebhookReceipt(j, out v) ? v : null; },
            [typeof(List<PaymentWebhookReceipt>)] = j => { List<PaymentWebhookReceipt> v; return ListOf<PaymentWebhookReceipt>(ReadPaymentWebhookReceipt)(j, out v) ? v : null; },
            [typeof(PlayResultStat)] = j => { PlayResultStat v; return ReadPlayResultStat(j, out v) ? v : null; },
            [typeof(List<PlayResultStat>)] = j => { List<PlayResultStat> v; return ListOf<PlayResultStat>(ReadPlayResultStat)(j, out v) ? v : null; },
            [typeof(PlayResult)] = j => { PlayResult v; return ReadPlayResult(j, out v) ? v : null; },
            [typeof(List<PlayResult>)] = j => { List<PlayResult> v; return ListOf<PlayResult>(ReadPlayResult)(j, out v) ? v : null; },
            [typeof(PlayResultEvent)] = j => { PlayResultEvent v; return ReadPlayResultEvent(j, out v) ? v : null; },
            [typeof(List<PlayResultEvent>)] = j => { List<PlayResultEvent> v; return ListOf<PlayResultEvent>(ReadPlayResultEvent)(j, out v) ? v : null; },
            [typeof(PlayResultEvents)] = j => { PlayResultEvents v; return ReadPlayResultEvents(j, out v) ? v : null; },
            [typeof(List<PlayResultEvents>)] = j => { List<PlayResultEvents> v; return ListOf<PlayResultEvents>(ReadPlayResultEvents)(j, out v) ? v : null; },
            [typeof(PlayerStats)] = j => { PlayerStats v; return ReadPlayerStats(j, out v) ? v : null; },
            [typeof(List<PlayerStats>)] = j => { List<PlayerStats> v; return ListOf<PlayerStats>(ReadPlayerStats)(j, out v) ? v : null; },
            [typeof(ProviderLinkStatus)] = j => { ProviderLinkStatus v; return ReadProviderLinkStatus(j, out v) ? v : null; },
            [typeof(List<ProviderLinkStatus>)] = j => { List<ProviderLinkStatus> v; return ListOf<ProviderLinkStatus>(ReadProviderLinkStatus)(j, out v) ? v : null; },
            [typeof(PublicUser)] = j => { PublicUser v; return ReadPublicUser(j, out v) ? v : null; },
            [typeof(List<PublicUser>)] = j => { List<PublicUser> v; return ListOf<PublicUser>(ReadPublicUser)(j, out v) ? v : null; },
            [typeof(Purchase)] = j => { Purchase v; return ReadPurchase(j, out v) ? v : null; },
            [typeof(List<Purchase>)] = j => { List<Purchase> v; return ListOf<Purchase>(ReadPurchase)(j, out v) ? v : null; },
            [typeof(PurchaseValidation)] = j => { PurchaseValidation v; return ReadPurchaseValidation(j, out v) ? v : null; },
            [typeof(List<PurchaseValidation>)] = j => { List<PurchaseValidation> v; return ListOf<PurchaseValidation>(ReadPurchaseValidation)(j, out v) ? v : null; },
            [typeof(PushToken)] = j => { PushToken v; return ReadPushToken(j, out v) ? v : null; },
            [typeof(List<PushToken>)] = j => { List<PushToken> v; return ListOf<PushToken>(ReadPushToken)(j, out v) ? v : null; },
            [typeof(QuestObjective)] = j => { QuestObjective v; return ReadQuestObjective(j, out v) ? v : null; },
            [typeof(List<QuestObjective>)] = j => { List<QuestObjective> v; return ListOf<QuestObjective>(ReadQuestObjective)(j, out v) ? v : null; },
            [typeof(QuestProgress)] = j => { QuestProgress v; return ReadQuestProgress(j, out v) ? v : null; },
            [typeof(List<QuestProgress>)] = j => { List<QuestProgress> v; return ListOf<QuestProgress>(ReadQuestProgress)(j, out v) ? v : null; },
            [typeof(QuestReward)] = j => { QuestReward v; return ReadQuestReward(j, out v) ? v : null; },
            [typeof(List<QuestReward>)] = j => { List<QuestReward> v; return ListOf<QuestReward>(ReadQuestReward)(j, out v) ? v : null; },
            [typeof(Quest)] = j => { Quest v; return ReadQuest(j, out v) ? v : null; },
            [typeof(List<Quest>)] = j => { List<Quest> v; return ListOf<Quest>(ReadQuest)(j, out v) ? v : null; },
            [typeof(QuestClaim)] = j => { QuestClaim v; return ReadQuestClaim(j, out v) ? v : null; },
            [typeof(List<QuestClaim>)] = j => { List<QuestClaim> v; return ListOf<QuestClaim>(ReadQuestClaim)(j, out v) ? v : null; },
            [typeof(QuestStats)] = j => { QuestStats v; return ReadQuestStats(j, out v) ? v : null; },
            [typeof(List<QuestStats>)] = j => { List<QuestStats> v; return ListOf<QuestStats>(ReadQuestStats)(j, out v) ? v : null; },
            [typeof(Registration)] = j => { Registration v; return ReadRegistration(j, out v) ? v : null; },
            [typeof(List<Registration>)] = j => { List<Registration> v; return ListOf<Registration>(ReadRegistration)(j, out v) ? v : null; },
            [typeof(ReportKind)] = j => { ReportKind v; return ReadReportKind(j, out v) ? v : null; },
            [typeof(List<ReportKind>)] = j => { List<ReportKind> v; return ListOf<ReportKind>(ReadReportKind)(j, out v) ? v : null; },
            [typeof(ReportKinds)] = j => { ReportKinds v; return ReadReportKinds(j, out v) ? v : null; },
            [typeof(List<ReportKinds>)] = j => { List<ReportKinds> v; return ListOf<ReportKinds>(ReadReportKinds)(j, out v) ? v : null; },
            [typeof(ReportReceipt)] = j => { ReportReceipt v; return ReadReportReceipt(j, out v) ? v : null; },
            [typeof(List<ReportReceipt>)] = j => { List<ReportReceipt> v; return ListOf<ReportReceipt>(ReadReportReceipt)(j, out v) ? v : null; },
            [typeof(ReportRequest)] = j => { ReportRequest v; return ReadReportRequest(j, out v) ? v : null; },
            [typeof(List<ReportRequest>)] = j => { List<ReportRequest> v; return ListOf<ReportRequest>(ReadReportRequest)(j, out v) ? v : null; },
            [typeof(SignalingStats)] = j => { SignalingStats v; return ReadSignalingStats(j, out v) ? v : null; },
            [typeof(List<SignalingStats>)] = j => { List<SignalingStats> v; return ListOf<SignalingStats>(ReadSignalingStats)(j, out v) ? v : null; },
            [typeof(TournamentMatchCounts)] = j => { TournamentMatchCounts v; return ReadTournamentMatchCounts(j, out v) ? v : null; },
            [typeof(List<TournamentMatchCounts>)] = j => { List<TournamentMatchCounts> v; return ListOf<TournamentMatchCounts>(ReadTournamentMatchCounts)(j, out v) ? v : null; },
            [typeof(TournamentStats)] = j => { TournamentStats v; return ReadTournamentStats(j, out v) ? v : null; },
            [typeof(List<TournamentStats>)] = j => { List<TournamentStats> v; return ListOf<TournamentStats>(ReadTournamentStats)(j, out v) ? v : null; },
            [typeof(ServerStats)] = j => { ServerStats v; return ReadServerStats(j, out v) ? v : null; },
            [typeof(List<ServerStats>)] = j => { List<ServerStats> v; return ListOf<ServerStats>(ReadServerStats)(j, out v) ? v : null; },
            [typeof(ServerTime)] = j => { ServerTime v; return ReadServerTime(j, out v) ? v : null; },
            [typeof(List<ServerTime>)] = j => { List<ServerTime> v; return ListOf<ServerTime>(ReadServerTime)(j, out v) ? v : null; },
            [typeof(SteamCheckout)] = j => { SteamCheckout v; return ReadSteamCheckout(j, out v) ? v : null; },
            [typeof(List<SteamCheckout>)] = j => { List<SteamCheckout> v; return ListOf<SteamCheckout>(ReadSteamCheckout)(j, out v) ? v : null; },
            [typeof(StripeCheckout)] = j => { StripeCheckout v; return ReadStripeCheckout(j, out v) ? v : null; },
            [typeof(List<StripeCheckout>)] = j => { List<StripeCheckout> v; return ListOf<StripeCheckout>(ReadStripeCheckout)(j, out v) ? v : null; },
            [typeof(TournamentEntry)] = j => { TournamentEntry v; return ReadTournamentEntry(j, out v) ? v : null; },
            [typeof(List<TournamentEntry>)] = j => { List<TournamentEntry> v; return ListOf<TournamentEntry>(ReadTournamentEntry)(j, out v) ? v : null; },
            [typeof(Tournament)] = j => { Tournament v; return ReadTournament(j, out v) ? v : null; },
            [typeof(List<Tournament>)] = j => { List<Tournament> v; return ListOf<Tournament>(ReadTournament)(j, out v) ? v : null; },
            [typeof(TournamentMatch)] = j => { TournamentMatch v; return ReadTournamentMatch(j, out v) ? v : null; },
            [typeof(List<TournamentMatch>)] = j => { List<TournamentMatch> v; return ListOf<TournamentMatch>(ReadTournamentMatch)(j, out v) ? v : null; },
            [typeof(TournamentBracket)] = j => { TournamentBracket v; return ReadTournamentBracket(j, out v) ? v : null; },
            [typeof(List<TournamentBracket>)] = j => { List<TournamentBracket> v; return ListOf<TournamentBracket>(ReadTournamentBracket)(j, out v) ? v : null; },
            [typeof(TournamentPlacement)] = j => { TournamentPlacement v; return ReadTournamentPlacement(j, out v) ? v : null; },
            [typeof(List<TournamentPlacement>)] = j => { List<TournamentPlacement> v; return ListOf<TournamentPlacement>(ReadTournamentPlacement)(j, out v) ? v : null; },
            [typeof(TournamentStandings)] = j => { TournamentStandings v; return ReadTournamentStandings(j, out v) ? v : null; },
            [typeof(List<TournamentStandings>)] = j => { List<TournamentStandings> v; return ListOf<TournamentStandings>(ReadTournamentStandings)(j, out v) ? v : null; },
            [typeof(UploadTicket)] = j => { UploadTicket v; return ReadUploadTicket(j, out v) ? v : null; },
            [typeof(List<UploadTicket>)] = j => { List<UploadTicket> v; return ListOf<UploadTicket>(ReadUploadTicket)(j, out v) ? v : null; },
            [typeof(WalletBalances)] = j => { WalletBalances v; return ReadWalletBalances(j, out v) ? v : null; },
            [typeof(List<WalletBalances>)] = j => { List<WalletBalances> v; return ListOf<WalletBalances>(ReadWalletBalances)(j, out v) ? v : null; },
        };
    }
}
