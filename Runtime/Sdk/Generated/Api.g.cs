// Written by clients/sdkgen (csharp) from the OpenAPI document.
// Do not edit; edit the generator or the spec and run
// clients/generate_csharp.sh.
//
// Every Gamend operation a game can call, one method each, named as the
// Godot SDK names it. A method takes the path's own parameters, then `body`
// for the request body and `options` for the query where the operation has
// them, and answers a task that `Client.Poll()` completes:
//
//     var body = new JObject { ["title"] = "duel", ["max_users"] = 2 };
//     var reply = await client.Api.LobbiesQuickJoin(body);
//     if (reply.Ok) Use(reply.Data);
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Gamend
{
    /// <summary>Every REST operation, one method each.</summary>
    public sealed class Api
    {
        private readonly Rest _rest;

        internal Api(Rest rest)
        {
            _rest = rest;
        }

        // Authentication

        /// <summary>
        /// Confirm a registration with its code
        /// </summary>
        /// <remarks>
        /// POST /api/v1/register/confirm
        /// body: email (required), code (required), password (required).
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateConfirmRegistration(JObject body)
        {
            if (!Query.Given(body, "email")) return _rest.Refuse("AuthenticateConfirmRegistration", "email");
            if (!Query.Given(body, "code")) return _rest.Refuse("AuthenticateConfirmRegistration", "code");
            if (!Query.Given(body, "password")) return _rest.Refuse("AuthenticateConfirmRegistration", "password");
            var path = "/api/v1/register/confirm";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Device login
        /// </summary>
        /// <remarks>
        /// POST /api/v1/login/device
        /// body: device_id (required).
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateDeviceLogin(JObject body)
        {
            if (!Query.Given(body, "device_id")) return _rest.Refuse("AuthenticateDeviceLogin", "device_id");
            var path = "/api/v1/login/device";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Link Apple (native iOS)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/providers/apple/ios
        /// body: code (required), family_name, given_name.
        /// </remarks>
        public Task<Response> AuthenticateLinkAppleIos(JObject body)
        {
            if (!Query.Given(body, "code")) return _rest.Refuse("AuthenticateLinkAppleIos", "code");
            var path = "/api/v1/me/providers/apple/ios";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Link device ID
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/device
        /// body: device_id (required).
        /// </remarks>
        public Task<Response> AuthenticateLinkDevice(JObject body)
        {
            if (!Query.Given(body, "device_id")) return _rest.Refuse("AuthenticateLinkDevice", "device_id");
            var path = "/api/v1/me/device";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Link Google with an ID token
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/providers/google/id_token
        /// body: id_token (required).
        /// </remarks>
        public Task<Response> AuthenticateLinkGoogleIdToken(JObject body)
        {
            if (!Query.Given(body, "id_token")) return _rest.Refuse("AuthenticateLinkGoogleIdToken", "id_token");
            var path = "/api/v1/me/providers/google/id_token";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Link a provider with a code
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/providers/{provider}
        /// body: code (required).
        /// </remarks>
        public Task<Response> AuthenticateLinkProvider(string provider, JObject body)
        {
            if (string.IsNullOrEmpty(provider)) return _rest.Refuse("AuthenticateLinkProvider", "provider");
            if (!Query.Given(body, "code")) return _rest.Refuse("AuthenticateLinkProvider", "code");
            var path = "/api/v1/me/providers/" + Query.Escape(provider);
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Start linking a provider
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/providers/{provider}/authorize
        /// </remarks>
        public Task<Response> AuthenticateLinkProviderRequest(string provider)
        {
            if (string.IsNullOrEmpty(provider)) return _rest.Refuse("AuthenticateLinkProviderRequest", "provider");
            var path = "/api/v1/me/providers/" + Query.Escape(provider) + "/authorize";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Poll a provider link
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/providers/sessions/{session_id}
        /// </remarks>
        public Task<Response> AuthenticateLinkSessionStatus(string sessionId)
        {
            if (string.IsNullOrEmpty(sessionId)) return _rest.Refuse("AuthenticateLinkSessionStatus", "session_id");
            var path = "/api/v1/me/providers/sessions/" + Query.Escape(sessionId);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List sign-in providers
        /// </summary>
        /// <remarks>
        /// GET /api/v1/auth/providers
        /// </remarks>
        public Task<Response> AuthenticateListAuthProviders()
        {
            var path = "/api/v1/auth/providers";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <remarks>
        /// POST /api/v1/login
        /// body: email (required), password (required).
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateLogin(JObject body)
        {
            if (!Query.Given(body, "email")) return _rest.Refuse("AuthenticateLogin", "email");
            if (!Query.Given(body, "password")) return _rest.Refuse("AuthenticateLogin", "password");
            var path = "/api/v1/login";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/logout
        /// </remarks>
        public Task<Response> AuthenticateLogout()
        {
            var path = "/api/v1/logout";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Sign in with a provider code
        /// </summary>
        /// <remarks>
        /// POST /api/v1/auth/{provider}/callback
        /// body: code (required).
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateOauthApiCallback(string provider, JObject body)
        {
            if (string.IsNullOrEmpty(provider)) return _rest.Refuse("AuthenticateOauthApiCallback", "provider");
            if (!Query.Given(body, "code")) return _rest.Refuse("AuthenticateOauthApiCallback", "code");
            var path = "/api/v1/auth/" + Query.Escape(provider) + "/callback";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Sign in with Apple (native iOS)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/auth/apple/ios/callback
        /// body: code (required), family_name, given_name.
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateOauthCallbackApiAppleIos(JObject body)
        {
            if (!Query.Given(body, "code")) return _rest.Refuse("AuthenticateOauthCallbackApiAppleIos", "code");
            var path = "/api/v1/auth/apple/ios/callback";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Sign in with a Google ID token
        /// </summary>
        /// <remarks>
        /// POST /api/v1/auth/google/id_token
        /// body: id_token (required).
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateOauthGoogleIdToken(JObject body)
        {
            if (!Query.Given(body, "id_token")) return _rest.Refuse("AuthenticateOauthGoogleIdToken", "id_token");
            var path = "/api/v1/auth/google/id_token";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Start a provider sign-in
        /// </summary>
        /// <remarks>
        /// GET /api/v1/auth/{provider}
        /// </remarks>
        public Task<Response> AuthenticateOauthRequest(string provider)
        {
            if (string.IsNullOrEmpty(provider)) return _rest.Refuse("AuthenticateOauthRequest", "provider");
            var path = "/api/v1/auth/" + Query.Escape(provider);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Poll a provider sign-in
        /// </summary>
        /// <remarks>
        /// GET /api/v1/auth/session/{session_id}
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateOauthSessionStatus(string sessionId)
        {
            if (string.IsNullOrEmpty(sessionId)) return _rest.Refuse("AuthenticateOauthSessionStatus", "session_id");
            var path = "/api/v1/auth/session/" + Query.Escape(sessionId);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Refresh access token
        /// </summary>
        /// <remarks>
        /// POST /api/v1/refresh
        /// body: refresh_token (required).
        /// Answers a session without keeping it: Client.Auth signs in.
        /// </remarks>
        public Task<Response> AuthenticateRefreshToken(JObject body)
        {
            if (!Query.Given(body, "refresh_token")) return _rest.Refuse("AuthenticateRefreshToken", "refresh_token");
            var path = "/api/v1/refresh";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <remarks>
        /// POST /api/v1/register
        /// body: email (required), captcha_token, username.
        /// </remarks>
        public Task<Response> AuthenticateRegister(JObject body)
        {
            if (!Query.Given(body, "email")) return _rest.Refuse("AuthenticateRegister", "email");
            var path = "/api/v1/register";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Send the confirmation email again
        /// </summary>
        /// <remarks>
        /// POST /api/v1/register/resend
        /// body: email (required).
        /// </remarks>
        public Task<Response> AuthenticateResendConfirmation(JObject body)
        {
            if (!Query.Given(body, "email")) return _rest.Refuse("AuthenticateResendConfirmation", "email");
            var path = "/api/v1/register/resend";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Unlink device ID
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/me/device
        /// </remarks>
        public Task<Response> AuthenticateUnlinkDevice()
        {
            var path = "/api/v1/me/device";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Unlink OAuth provider
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/me/providers/{provider}
        /// </remarks>
        public Task<Response> AuthenticateUnlinkProvider(string provider)
        {
            if (string.IsNullOrEmpty(provider)) return _rest.Refuse("AuthenticateUnlinkProvider", "provider");
            var path = "/api/v1/me/providers/" + Query.Escape(provider);
            return _rest.Send("DELETE", path, Body.None);
        }

        // Chat

        /// <summary>
        /// Get unread message count
        /// </summary>
        /// <remarks>
        /// GET /api/v1/chat/unread
        /// options: chat_type (required), chat_ref_id (required).
        /// </remarks>
        public Task<Response> ChatChatUnreadCount(JObject options)
        {
            if (!Query.Given(options, "chat_type")) return _rest.Refuse("ChatChatUnreadCount", "chat_type");
            if (!Query.Given(options, "chat_ref_id")) return _rest.Refuse("ChatChatUnreadCount", "chat_ref_id");
            var path = "/api/v1/chat/unread";
            path += Query.Build(options, "chat_type", "chat_ref_id");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Delete your own chat message
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/chat/messages/{id}
        /// </remarks>
        public Task<Response> ChatDeleteChatMessage(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatDeleteChatMessage", "id");
            var path = "/api/v1/chat/messages/" + Query.Escape(id);
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Get a single chat message
        /// </summary>
        /// <remarks>
        /// GET /api/v1/chat/messages/{id}
        /// </remarks>
        public Task<Response> ChatGetChatMessage(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatGetChatMessage", "id");
            var path = "/api/v1/chat/messages/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List chat messages
        /// </summary>
        /// <remarks>
        /// GET /api/v1/chat/messages
        /// options: chat_type (required), chat_ref_id (required), page, page_size.
        /// </remarks>
        public Task<Response> ChatListChatMessages(JObject options)
        {
            if (!Query.Given(options, "chat_type")) return _rest.Refuse("ChatListChatMessages", "chat_type");
            if (!Query.Given(options, "chat_ref_id")) return _rest.Refuse("ChatListChatMessages", "chat_ref_id");
            var path = "/api/v1/chat/messages";
            path += Query.Build(options, "chat_type", "chat_ref_id", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List active mutes in a group
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/{id}/mutes
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> ChatListGroupMutes(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatListGroupMutes", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/mutes";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List active mutes in a group
        /// </summary>
        public Task<Response> ChatListGroupMutes(string id)
        {
            return ChatListGroupMutes(id, null);
        }

        /// <summary>
        /// List active mutes in your lobby
        /// </summary>
        /// <remarks>
        /// GET /api/v1/lobbies/mutes
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> ChatListLobbyMutes(JObject options)
        {
            var path = "/api/v1/lobbies/mutes";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List active mutes in your lobby
        /// </summary>
        public Task<Response> ChatListLobbyMutes()
        {
            return ChatListLobbyMutes(null);
        }

        /// <summary>
        /// List active mutes in your party
        /// </summary>
        /// <remarks>
        /// GET /api/v1/parties/mutes
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> ChatListPartyMutes(JObject options)
        {
            var path = "/api/v1/parties/mutes";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List active mutes in your party
        /// </summary>
        public Task<Response> ChatListPartyMutes()
        {
            return ChatListPartyMutes(null);
        }

        /// <summary>
        /// Mark chat as read
        /// </summary>
        /// <remarks>
        /// POST /api/v1/chat/read
        /// body: chat_type (required), chat_ref_id (required), message_id (required).
        /// </remarks>
        public Task<Response> ChatMarkChatRead(JObject body)
        {
            if (!Query.Given(body, "chat_type")) return _rest.Refuse("ChatMarkChatRead", "chat_type");
            if (!Query.Given(body, "chat_ref_id")) return _rest.Refuse("ChatMarkChatRead", "chat_ref_id");
            if (!Query.Given(body, "message_id")) return _rest.Refuse("ChatMarkChatRead", "message_id");
            var path = "/api/v1/chat/read";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Mute a player in a group
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/mute
        /// body: target_user_id (required), expires_at, reason.
        /// </remarks>
        public Task<Response> ChatMuteGroupMember(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatMuteGroupMember", "id");
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("ChatMuteGroupMember", "target_user_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/mute";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Mute a player in your lobby
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/mute
        /// body: target_user_id (required), expires_at, reason.
        /// </remarks>
        public Task<Response> ChatMuteLobbyMember(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("ChatMuteLobbyMember", "target_user_id");
            var path = "/api/v1/lobbies/mute";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Mute a player in your party
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/mute
        /// body: target_user_id (required), expires_at, reason.
        /// </remarks>
        public Task<Response> ChatMutePartyMember(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("ChatMutePartyMember", "target_user_id");
            var path = "/api/v1/parties/mute";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Report a chat message
        /// </summary>
        /// <remarks>
        /// POST /api/v1/chat/messages/{id}/report
        /// body: reason.
        /// </remarks>
        public Task<Response> ChatReportChatMessage(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatReportChatMessage", "id");
            var path = "/api/v1/chat/messages/" + Query.Escape(id) + "/report";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Send a chat message
        /// </summary>
        /// <remarks>
        /// POST /api/v1/chat/messages
        /// body: chat_type (required), chat_ref_id (required), content (required), metadata.
        /// </remarks>
        public Task<Response> ChatSendChatMessage(JObject body)
        {
            if (!Query.Given(body, "chat_type")) return _rest.Refuse("ChatSendChatMessage", "chat_type");
            if (!Query.Given(body, "chat_ref_id")) return _rest.Refuse("ChatSendChatMessage", "chat_ref_id");
            if (!Query.Given(body, "content")) return _rest.Refuse("ChatSendChatMessage", "content");
            var path = "/api/v1/chat/messages";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Lift a mute in a group
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/unmute
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> ChatUnmuteGroupMember(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatUnmuteGroupMember", "id");
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("ChatUnmuteGroupMember", "target_user_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/unmute";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Lift a mute in your lobby
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/unmute
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> ChatUnmuteLobbyMember(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("ChatUnmuteLobbyMember", "target_user_id");
            var path = "/api/v1/lobbies/unmute";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Lift a mute in your party
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/unmute
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> ChatUnmutePartyMember(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("ChatUnmutePartyMember", "target_user_id");
            var path = "/api/v1/parties/unmute";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Update your own chat message
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/chat/messages/{id}
        /// body: content, metadata.
        /// </remarks>
        public Task<Response> ChatUpdateChatMessage(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ChatUpdateChatMessage", "id");
            var path = "/api/v1/chat/messages/" + Query.Escape(id);
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        // Client logs

        /// <summary>
        /// Client log capture policy
        /// </summary>
        /// <remarks>
        /// GET /api/v1/client_logs/policy
        /// </remarks>
        public Task<Response> ClientLogsGetClientLogPolicy()
        {
            var path = "/api/v1/client_logs/policy";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Upload a batch of client log entries
        /// </summary>
        /// <remarks>
        /// POST /api/v1/client_logs
        /// body: session (required), entries (required).
        /// </remarks>
        public Task<Response> ClientLogsUploadClientLogs(JObject body)
        {
            if (!Query.Given(body, "session")) return _rest.Refuse("ClientLogsUploadClientLogs", "session");
            if (!Query.Given(body, "entries")) return _rest.Refuse("ClientLogsUploadClientLogs", "entries");
            var path = "/api/v1/client_logs";
            return _rest.Send("POST", path, Body.Of(body));
        }

        // Economy

        /// <summary>
        /// Current user's item quantities
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/inventory
        /// </remarks>
        public Task<Response> EconomyGetCurrentUserInventory()
        {
            var path = "/api/v1/me/inventory";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Current user's currency balances
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/wallet
        /// </remarks>
        public Task<Response> EconomyGetCurrentUserWallet()
        {
            var path = "/api/v1/me/wallet";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Current user's ledger history
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/wallet/ledger
        /// options: currency, page, page_size.
        /// </remarks>
        public Task<Response> EconomyListCurrentUserLedger(JObject options)
        {
            var path = "/api/v1/me/wallet/ledger";
            path += Query.Build(options, "currency", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Current user's ledger history
        /// </summary>
        public Task<Response> EconomyListCurrentUserLedger()
        {
            return EconomyListCurrentUserLedger(null);
        }

        // Friends

        /// <summary>
        /// Accept a friend request
        /// </summary>
        /// <remarks>
        /// POST /api/v1/friends/{id}/accept
        /// </remarks>
        public Task<Response> FriendsAcceptFriendRequest(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("FriendsAcceptFriendRequest", "id");
            var path = "/api/v1/friends/" + Query.Escape(id) + "/accept";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Block a friend request / user
        /// </summary>
        /// <remarks>
        /// POST /api/v1/friends/{id}/block
        /// </remarks>
        public Task<Response> FriendsBlockFriendRequest(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("FriendsBlockFriendRequest", "id");
            var path = "/api/v1/friends/" + Query.Escape(id) + "/block";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Blacklist a user, with or without an existing friendship
        /// </summary>
        /// <remarks>
        /// POST /api/v1/users/{user_id}/block
        /// </remarks>
        public Task<Response> FriendsBlockUser(string userId)
        {
            if (string.IsNullOrEmpty(userId)) return _rest.Refuse("FriendsBlockUser", "user_id");
            var path = "/api/v1/users/" + Query.Escape(userId) + "/block";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Send a friend request
        /// </summary>
        /// <remarks>
        /// POST /api/v1/friends
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> FriendsCreateFriendRequest(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("FriendsCreateFriendRequest", "target_user_id");
            var path = "/api/v1/friends";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// List the users you've blocked
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/blacklist
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> FriendsListBlacklistedUsers(JObject options)
        {
            var path = "/api/v1/me/blacklist";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List the users you've blocked
        /// </summary>
        public Task<Response> FriendsListBlacklistedUsers()
        {
            return FriendsListBlacklistedUsers(null);
        }

        /// <summary>
        /// List users you've blocked
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/blocked
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> FriendsListBlockedFriends(JObject options)
        {
            var path = "/api/v1/me/blocked";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List users you've blocked
        /// </summary>
        public Task<Response> FriendsListBlockedFriends()
        {
            return FriendsListBlockedFriends(null);
        }

        /// <summary>
        /// List pending friend requests (incoming and outgoing)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/friend_requests
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> FriendsListFriendRequests(JObject options)
        {
            var path = "/api/v1/me/friend_requests";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List pending friend requests (incoming and outgoing)
        /// </summary>
        public Task<Response> FriendsListFriendRequests()
        {
            return FriendsListFriendRequests(null);
        }

        /// <summary>
        /// List current user's friends (returns a paginated set of user objects)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/friends
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> FriendsListFriends(JObject options)
        {
            var path = "/api/v1/me/friends";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List current user's friends (returns a paginated set of user objects)
        /// </summary>
        public Task<Response> FriendsListFriends()
        {
            return FriendsListFriends(null);
        }

        /// <summary>
        /// Reject a friend request
        /// </summary>
        /// <remarks>
        /// POST /api/v1/friends/{id}/reject
        /// </remarks>
        public Task<Response> FriendsRejectFriendRequest(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("FriendsRejectFriendRequest", "id");
            var path = "/api/v1/friends/" + Query.Escape(id) + "/reject";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Remove/cancel a friendship or request
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/friends/{id}
        /// </remarks>
        public Task<Response> FriendsRemoveFriendship(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("FriendsRemoveFriendship", "id");
            var path = "/api/v1/friends/" + Query.Escape(id);
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Unblock a previously-blocked friendship
        /// </summary>
        /// <remarks>
        /// POST /api/v1/friends/{id}/unblock
        /// </remarks>
        public Task<Response> FriendsUnblockFriend(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("FriendsUnblockFriend", "id");
            var path = "/api/v1/friends/" + Query.Escape(id) + "/unblock";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Remove a user from your blacklist
        /// </summary>
        /// <remarks>
        /// POST /api/v1/users/{user_id}/unblock
        /// </remarks>
        public Task<Response> FriendsUnblockUser(string userId)
        {
            if (string.IsNullOrEmpty(userId)) return _rest.Refuse("FriendsUnblockUser", "user_id");
            var path = "/api/v1/users/" + Query.Escape(userId) + "/unblock";
            return _rest.Send("POST", path, Body.None);
        }

        // Groups

        /// <summary>
        /// Accept a group invitation
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/invitations/{invite_id}/accept
        /// </remarks>
        public Task<Response> GroupsAcceptGroupInvite(string inviteId)
        {
            if (string.IsNullOrEmpty(inviteId)) return _rest.Refuse("GroupsAcceptGroupInvite", "invite_id");
            var path = "/api/v1/groups/invitations/" + Query.Escape(inviteId) + "/accept";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Approve a join request (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/join_requests/{request_id}/approve
        /// </remarks>
        public Task<Response> GroupsApproveJoinRequest(string id, string requestId)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsApproveJoinRequest", "id");
            if (string.IsNullOrEmpty(requestId)) return _rest.Refuse("GroupsApproveJoinRequest", "request_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/join_requests/" + Query.Escape(requestId) + "/approve";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Cancel a pending group invitation
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/groups/sent_invitations/{invite_id}
        /// </remarks>
        public Task<Response> GroupsCancelGroupInvite(string inviteId)
        {
            if (string.IsNullOrEmpty(inviteId)) return _rest.Refuse("GroupsCancelGroupInvite", "invite_id");
            var path = "/api/v1/groups/sent_invitations/" + Query.Escape(inviteId);
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Cancel your own pending join request
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/groups/{id}/join_requests/{request_id}
        /// </remarks>
        public Task<Response> GroupsCancelJoinRequest(string id, string requestId)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsCancelJoinRequest", "id");
            if (string.IsNullOrEmpty(requestId)) return _rest.Refuse("GroupsCancelJoinRequest", "request_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/join_requests/" + Query.Escape(requestId);
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Create a group
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups
        /// body: title (required), description, icon_url, max_members, metadata, slowdown,
        /// slug, type.
        /// </remarks>
        public Task<Response> GroupsCreateGroup(JObject body)
        {
            if (!Query.Given(body, "title")) return _rest.Refuse("GroupsCreateGroup", "title");
            var path = "/api/v1/groups";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Request a group icon upload ticket (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/icon/upload_url
        /// body: content_type (required).
        /// </remarks>
        public Task<Response> GroupsCreateGroupIconUploadUrl(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsCreateGroupIconUploadUrl", "id");
            if (!Query.Given(body, "content_type")) return _rest.Refuse("GroupsCreateGroupIconUploadUrl", "content_type");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/icon/upload_url";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Make a group's invite link (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/invite_link
        /// </remarks>
        public Task<Response> GroupsCreateGroupInviteLink(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsCreateGroupInviteLink", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/invite_link";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Decline a group invitation
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/invitations/{invite_id}/decline
        /// </remarks>
        public Task<Response> GroupsDeclineGroupInvite(string inviteId)
        {
            if (string.IsNullOrEmpty(inviteId)) return _rest.Refuse("GroupsDeclineGroupInvite", "invite_id");
            var path = "/api/v1/groups/invitations/" + Query.Escape(inviteId) + "/decline";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Delete a group (admin only)
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/groups/{id}
        /// </remarks>
        public Task<Response> GroupsDeleteGroup(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsDeleteGroup", "id");
            var path = "/api/v1/groups/" + Query.Escape(id);
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Turn a group's invite link off (admin only)
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/groups/{id}/invite_link
        /// </remarks>
        public Task<Response> GroupsDeleteGroupInviteLink(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsDeleteGroupInviteLink", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/invite_link";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Demote admin to member
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/demote
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> GroupsDemoteGroupMember(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsDemoteGroupMember", "id");
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("GroupsDemoteGroupMember", "target_user_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/demote";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Get group details
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/{id}
        /// </remarks>
        public Task<Response> GroupsGetGroup(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsGetGroup", "id");
            var path = "/api/v1/groups/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Get a group's invite link (admin only)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/{id}/invite_link
        /// </remarks>
        public Task<Response> GroupsGetGroupInviteLink(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsGetGroupInviteLink", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/invite_link";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Invite a user to a group (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/invite
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> GroupsInviteToGroup(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsInviteToGroup", "id");
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("GroupsInviteToGroup", "target_user_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/invite";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Join a group
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/join
        /// </remarks>
        public Task<Response> GroupsJoinGroup(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsJoinGroup", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/join";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Join a group through its invite link
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/invite_links/{token}/join
        /// </remarks>
        public Task<Response> GroupsJoinGroupByInviteLink(string token)
        {
            if (string.IsNullOrEmpty(token)) return _rest.Refuse("GroupsJoinGroupByInviteLink", "token");
            var path = "/api/v1/groups/invite_links/" + Query.Escape(token) + "/join";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Kick a member (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/kick
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> GroupsKickGroupMember(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsKickGroupMember", "id");
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("GroupsKickGroupMember", "target_user_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/kick";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Leave a group
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/leave
        /// </remarks>
        public Task<Response> GroupsLeaveGroup(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsLeaveGroup", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/leave";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// List my group invitations
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/invitations
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> GroupsListGroupInvitations(JObject options)
        {
            var path = "/api/v1/groups/invitations";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List my group invitations
        /// </summary>
        public Task<Response> GroupsListGroupInvitations()
        {
            return GroupsListGroupInvitations(null);
        }

        /// <summary>
        /// List a group's pending invitations (admin only)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/{id}/invites
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> GroupsListGroupInvites(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsListGroupInvites", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/invites";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List a group's pending invitations (admin only)
        /// </summary>
        public Task<Response> GroupsListGroupInvites(string id)
        {
            return GroupsListGroupInvites(id, null);
        }

        /// <summary>
        /// List group members
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/{id}/members
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> GroupsListGroupMembers(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsListGroupMembers", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/members";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List group members
        /// </summary>
        public Task<Response> GroupsListGroupMembers(string id)
        {
            return GroupsListGroupMembers(id, null);
        }

        /// <summary>
        /// List groups
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups
        /// options: title, type, min_members, max_members, metadata_key, metadata_value, page,
        /// page_size.
        /// </remarks>
        public Task<Response> GroupsListGroups(JObject options)
        {
            var path = "/api/v1/groups";
            path += Query.Build(options, "title", "type", "min_members", "max_members", "metadata_key", "metadata_value", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List groups
        /// </summary>
        public Task<Response> GroupsListGroups()
        {
            return GroupsListGroups(null);
        }

        /// <summary>
        /// List pending join requests (admin only)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/{id}/join_requests
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> GroupsListJoinRequests(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsListJoinRequests", "id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/join_requests";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List pending join requests (admin only)
        /// </summary>
        public Task<Response> GroupsListJoinRequests(string id)
        {
            return GroupsListJoinRequests(id, null);
        }

        /// <summary>
        /// List groups I belong to
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/me
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> GroupsListMyGroups(JObject options)
        {
            var path = "/api/v1/groups/me";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List groups I belong to
        /// </summary>
        public Task<Response> GroupsListMyGroups()
        {
            return GroupsListMyGroups(null);
        }

        /// <summary>
        /// List group invitations I have sent
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/sent_invitations
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> GroupsListSentInvitations(JObject options)
        {
            var path = "/api/v1/groups/sent_invitations";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List group invitations I have sent
        /// </summary>
        public Task<Response> GroupsListSentInvitations()
        {
            return GroupsListSentInvitations(null);
        }

        /// <summary>
        /// See the group an invite link opens
        /// </summary>
        /// <remarks>
        /// GET /api/v1/groups/invite_links/{token}
        /// </remarks>
        public Task<Response> GroupsPreviewGroupInviteLink(string token)
        {
            if (string.IsNullOrEmpty(token)) return _rest.Refuse("GroupsPreviewGroupInviteLink", "token");
            var path = "/api/v1/groups/invite_links/" + Query.Escape(token);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Promote member to admin
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/promote
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> GroupsPromoteGroupMember(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsPromoteGroupMember", "id");
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("GroupsPromoteGroupMember", "target_user_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/promote";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Reject a join request (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/join_requests/{request_id}/reject
        /// </remarks>
        public Task<Response> GroupsRejectJoinRequest(string id, string requestId)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsRejectJoinRequest", "id");
            if (string.IsNullOrEmpty(requestId)) return _rest.Refuse("GroupsRejectJoinRequest", "request_id");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/join_requests/" + Query.Escape(requestId) + "/reject";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Confirm an uploaded group icon (admin only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/groups/{id}/icon
        /// body: key (required).
        /// </remarks>
        public Task<Response> GroupsSetGroupIcon(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsSetGroupIcon", "id");
            if (!Query.Given(body, "key")) return _rest.Refuse("GroupsSetGroupIcon", "key");
            var path = "/api/v1/groups/" + Query.Escape(id) + "/icon";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Update a group (admin only)
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/groups/{id}
        /// body: description, icon_url, max_members, metadata, slowdown, slug, title, type.
        /// </remarks>
        public Task<Response> GroupsUpdateGroup(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("GroupsUpdateGroup", "id");
            var path = "/api/v1/groups/" + Query.Escape(id);
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        // Health

        /// <summary>
        /// Health check
        /// </summary>
        /// <remarks>
        /// GET /api/v1/health
        /// </remarks>
        public Task<Response> HealthIndex()
        {
            var path = "/api/v1/health";
            return _rest.Send("GET", path, Body.None);
        }

        // Hooks

        /// <summary>
        /// Invoke a hook function
        /// </summary>
        /// <remarks>
        /// POST /api/v1/hooks/call
        /// body: plugin (required), fn (required), args.
        /// </remarks>
        public Task<Response> HooksCallHook(JObject body)
        {
            if (!Query.Given(body, "plugin")) return _rest.Refuse("HooksCallHook", "plugin");
            if (!Query.Given(body, "fn")) return _rest.Refuse("HooksCallHook", "fn");
            var path = "/api/v1/hooks/call";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// List available hook functions
        /// </summary>
        /// <remarks>
        /// GET /api/v1/hooks
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> HooksListHooks(JObject options)
        {
            var path = "/api/v1/hooks";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List available hook functions
        /// </summary>
        public Task<Response> HooksListHooks()
        {
            return HooksListHooks(null);
        }

        // KV

        /// <summary>
        /// Get a key/value entry
        /// </summary>
        /// <remarks>
        /// GET /api/v1/kv/{key}
        /// options: user_id, lobby_id.
        /// </remarks>
        public Task<Response> KvGetKv(string key, JObject options)
        {
            if (string.IsNullOrEmpty(key)) return _rest.Refuse("KvGetKv", "key");
            var path = "/api/v1/kv/" + Query.Escape(key);
            path += Query.Build(options, "user_id", "lobby_id");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Get a key/value entry
        /// </summary>
        public Task<Response> KvGetKv(string key)
        {
            return KvGetKv(key, null);
        }

        // Leaderboards

        /// <summary>
        /// Get a leaderboard by ID
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards/{id}
        /// </remarks>
        public Task<Response> LeaderboardsGetLeaderboard(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LeaderboardsGetLeaderboard", "id");
            var path = "/api/v1/leaderboards/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Get current user's record
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards/{id}/records/me
        /// options: key.
        /// </remarks>
        public Task<Response> LeaderboardsGetMyRecord(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LeaderboardsGetMyRecord", "id");
            var path = "/api/v1/leaderboards/" + Query.Escape(id) + "/records/me";
            path += Query.Build(options, "key");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Get current user's record
        /// </summary>
        public Task<Response> LeaderboardsGetMyRecord(string id)
        {
            return LeaderboardsGetMyRecord(id, null);
        }

        /// <summary>
        /// List a leaderboard's rankings
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards/{id}/keys
        /// options: prefix.
        /// </remarks>
        public Task<Response> LeaderboardsListLeaderboardKeys(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LeaderboardsListLeaderboardKeys", "id");
            var path = "/api/v1/leaderboards/" + Query.Escape(id) + "/keys";
            path += Query.Build(options, "prefix");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List a leaderboard's rankings
        /// </summary>
        public Task<Response> LeaderboardsListLeaderboardKeys(string id)
        {
            return LeaderboardsListLeaderboardKeys(id, null);
        }

        /// <summary>
        /// List leaderboard records
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards/{id}/records
        /// options: page, page_size, key.
        /// </remarks>
        public Task<Response> LeaderboardsListLeaderboardRecords(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LeaderboardsListLeaderboardRecords", "id");
            var path = "/api/v1/leaderboards/" + Query.Escape(id) + "/records";
            path += Query.Build(options, "page", "page_size", "key");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List leaderboard records
        /// </summary>
        public Task<Response> LeaderboardsListLeaderboardRecords(string id)
        {
            return LeaderboardsListLeaderboardRecords(id, null);
        }

        /// <summary>
        /// List leaderboards
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards
        /// options: slug, active, order_by, starts_after, starts_before, ends_after,
        /// ends_before, page, page_size.
        /// </remarks>
        public Task<Response> LeaderboardsListLeaderboards(JObject options)
        {
            var path = "/api/v1/leaderboards";
            path += Query.Build(options, "slug", "active", "order_by", "starts_after", "starts_before", "ends_after", "ends_before", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List leaderboards
        /// </summary>
        public Task<Response> LeaderboardsListLeaderboards()
        {
            return LeaderboardsListLeaderboards(null);
        }

        /// <summary>
        /// List the records just ahead of a score
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards/{id}/records/above
        /// options: score (required), limit, key.
        /// </remarks>
        public Task<Response> LeaderboardsListRecordsAbove(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LeaderboardsListRecordsAbove", "id");
            if (!Query.Given(options, "score")) return _rest.Refuse("LeaderboardsListRecordsAbove", "score");
            var path = "/api/v1/leaderboards/" + Query.Escape(id) + "/records/above";
            path += Query.Build(options, "score", "limit", "key");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List records around a user
        /// </summary>
        /// <remarks>
        /// GET /api/v1/leaderboards/{id}/records/around/{user_id}
        /// options: limit, key.
        /// </remarks>
        public Task<Response> LeaderboardsListRecordsAroundUser(string id, string userId, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LeaderboardsListRecordsAroundUser", "id");
            if (string.IsNullOrEmpty(userId)) return _rest.Refuse("LeaderboardsListRecordsAroundUser", "user_id");
            var path = "/api/v1/leaderboards/" + Query.Escape(id) + "/records/around/" + Query.Escape(userId);
            path += Query.Build(options, "limit", "key");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List records around a user
        /// </summary>
        public Task<Response> LeaderboardsListRecordsAroundUser(string id, string userId)
        {
            return LeaderboardsListRecordsAroundUser(id, userId, null);
        }

        /// <summary>
        /// Resolve multiple slugs to active leaderboards
        /// </summary>
        /// <remarks>
        /// POST /api/v1/leaderboards/resolve
        /// body: slugs (required).
        /// </remarks>
        public Task<Response> LeaderboardsResolveSlugs(JObject body)
        {
            if (!Query.Given(body, "slugs")) return _rest.Refuse("LeaderboardsResolveSlugs", "slugs");
            var path = "/api/v1/leaderboards/resolve";
            return _rest.Send("POST", path, Body.Of(body));
        }

        // Lobbies

        /// <summary>
        /// Create a lobby
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies
        /// body: is_hidden, is_locked, max_users, metadata, password, slowdown, title.
        /// </remarks>
        public Task<Response> LobbiesCreateLobby(JObject body)
        {
            var path = "/api/v1/lobbies";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Disband the current lobby (host only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/disband
        /// </remarks>
        public Task<Response> LobbiesDisbandLobby()
        {
            var path = "/api/v1/lobbies/disband";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Get a single lobby
        /// </summary>
        /// <remarks>
        /// GET /api/v1/lobbies/{id}
        /// </remarks>
        public Task<Response> LobbiesGetLobby(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LobbiesGetLobby", "id");
            var path = "/api/v1/lobbies/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Join a lobby
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/{id}/join
        /// body: password.
        /// </remarks>
        public Task<Response> LobbiesJoinLobby(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("LobbiesJoinLobby", "id");
            var path = "/api/v1/lobbies/" + Query.Escape(id) + "/join";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Kick a user from the lobby (host only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/kick
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> LobbiesKickUser(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("LobbiesKickUser", "target_user_id");
            var path = "/api/v1/lobbies/kick";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Leave the current lobby
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/leave
        /// </remarks>
        public Task<Response> LobbiesLeaveLobby()
        {
            var path = "/api/v1/lobbies/leave";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// List lobbies
        /// </summary>
        /// <remarks>
        /// GET /api/v1/lobbies
        /// options: title, is_passworded, is_locked, min_users, max_users, page, page_size,
        /// metadata_key, metadata_value.
        /// </remarks>
        public Task<Response> LobbiesListLobbies(JObject options)
        {
            var path = "/api/v1/lobbies";
            path += Query.Build(options, "title", "is_passworded", "is_locked", "min_users", "max_users", "page", "page_size", "metadata_key", "metadata_value");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List lobbies
        /// </summary>
        public Task<Response> LobbiesListLobbies()
        {
            return LobbiesListLobbies(null);
        }

        /// <summary>
        /// Lobby counts
        /// </summary>
        /// <remarks>
        /// GET /api/v1/lobbies/stats
        /// </remarks>
        public Task<Response> LobbiesLobbyStats()
        {
            var path = "/api/v1/lobbies/stats";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Quick-join or create a lobby
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/quick_join
        /// body: max_users, metadata, title.
        /// </remarks>
        public Task<Response> LobbiesQuickJoin(JObject body)
        {
            var path = "/api/v1/lobbies/quick_join";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Set lobby state (host or pinned WebRTC host)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/state
        /// body: state (required), lobby_id.
        /// </remarks>
        public Task<Response> LobbiesSetLobbyState(JObject body)
        {
            if (!Query.Given(body, "state")) return _rest.Refuse("LobbiesSetLobbyState", "state");
            var path = "/api/v1/lobbies/state";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Update lobby (host or pinned WebRTC host)
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/lobbies
        /// body: is_hidden, is_locked, lobby_id, max_users, metadata, password, slowdown,
        /// title.
        /// </remarks>
        public Task<Response> LobbiesUpdateLobby(JObject body)
        {
            var path = "/api/v1/lobbies";
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        // Matchmaking

        /// <summary>
        /// Leave the matchmaking queue
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/matchmaking/tickets
        /// </remarks>
        public Task<Response> MatchmakingCancel()
        {
            var path = "/api/v1/matchmaking/tickets";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Join the matchmaking queue
        /// </summary>
        /// <remarks>
        /// POST /api/v1/matchmaking/tickets
        /// body: match_params, max_players, min_players.
        /// </remarks>
        public Task<Response> MatchmakingJoin(JObject body)
        {
            var path = "/api/v1/matchmaking/tickets";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Get my current ticket
        /// </summary>
        /// <remarks>
        /// GET /api/v1/matchmaking/tickets/me
        /// </remarks>
        public Task<Response> MatchmakingMyTicket()
        {
            var path = "/api/v1/matchmaking/tickets/me";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Queue statistics
        /// </summary>
        /// <remarks>
        /// GET /api/v1/matchmaking/stats
        /// </remarks>
        public Task<Response> MatchmakingStats()
        {
            var path = "/api/v1/matchmaking/stats";
            return _rest.Send("GET", path, Body.None);
        }

        // Notifications

        /// <summary>
        /// Delete notifications by IDs
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/notifications
        /// body: ids (required).
        /// </remarks>
        public Task<Response> NotificationsDeleteNotifications(JObject body)
        {
            if (!Query.Given(body, "ids")) return _rest.Refuse("NotificationsDeleteNotifications", "ids");
            var path = "/api/v1/notifications";
            return _rest.Send("DELETE", path, Body.Of(body));
        }

        /// <summary>
        /// List own notifications
        /// </summary>
        /// <remarks>
        /// GET /api/v1/notifications
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> NotificationsListNotifications(JObject options)
        {
            var path = "/api/v1/notifications";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List own notifications
        /// </summary>
        public Task<Response> NotificationsListNotifications()
        {
            return NotificationsListNotifications(null);
        }

        /// <summary>
        /// Send a notification to a friend
        /// </summary>
        /// <remarks>
        /// POST /api/v1/notifications
        /// body: user_id (required), title (required), content, icon_url, metadata.
        /// </remarks>
        public Task<Response> NotificationsSendNotification(JObject body)
        {
            if (!Query.Given(body, "user_id")) return _rest.Refuse("NotificationsSendNotification", "user_id");
            if (!Query.Given(body, "title")) return _rest.Refuse("NotificationsSendNotification", "title");
            var path = "/api/v1/notifications";
            return _rest.Send("POST", path, Body.Of(body));
        }

        // Parties

        /// <summary>
        /// Accept a party invite
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/invite/accept
        /// body: party_id (required).
        /// </remarks>
        public Task<Response> PartiesAcceptPartyInvite(JObject body)
        {
            if (!Query.Given(body, "party_id")) return _rest.Refuse("PartiesAcceptPartyInvite", "party_id");
            var path = "/api/v1/parties/invite/accept";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Cancel a pending party invite (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/invite/cancel
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> PartiesCancelPartyInvite(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("PartiesCancelPartyInvite", "target_user_id");
            var path = "/api/v1/parties/invite/cancel";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Create a party
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties
        /// body: max_size, metadata.
        /// </remarks>
        public Task<Response> PartiesCreateParty(JObject body)
        {
            var path = "/api/v1/parties";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Decline a party invite
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/invite/decline
        /// body: party_id (required).
        /// </remarks>
        public Task<Response> PartiesDeclinePartyInvite(JObject body)
        {
            if (!Query.Given(body, "party_id")) return _rest.Refuse("PartiesDeclinePartyInvite", "party_id");
            var path = "/api/v1/parties/invite/decline";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Disband the current party (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/disband
        /// </remarks>
        public Task<Response> PartiesDisbandParty()
        {
            var path = "/api/v1/parties/disband";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Invite a user to the party (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/invite
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> PartiesInviteToParty(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("PartiesInviteToParty", "target_user_id");
            var path = "/api/v1/parties/invite";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Kick a member from the party (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/kick
        /// body: target_user_id (required).
        /// </remarks>
        public Task<Response> PartiesKickPartyMember(JObject body)
        {
            if (!Query.Given(body, "target_user_id")) return _rest.Refuse("PartiesKickPartyMember", "target_user_id");
            var path = "/api/v1/parties/kick";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Leave the current party
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/leave
        /// </remarks>
        public Task<Response> PartiesLeaveParty()
        {
            var path = "/api/v1/parties/leave";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// List pending party invites for the current user
        /// </summary>
        /// <remarks>
        /// GET /api/v1/parties/invitations
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> PartiesListPartyInvitations(JObject options)
        {
            var path = "/api/v1/parties/invitations";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List pending party invites for the current user
        /// </summary>
        public Task<Response> PartiesListPartyInvitations()
        {
            return PartiesListPartyInvitations(null);
        }

        /// <summary>
        /// List pending party invites sent by the current leader
        /// </summary>
        /// <remarks>
        /// GET /api/v1/parties/invitations/sent
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> PartiesListSentPartyInvitations(JObject options)
        {
            var path = "/api/v1/parties/invitations/sent";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List pending party invites sent by the current leader
        /// </summary>
        public Task<Response> PartiesListSentPartyInvitations()
        {
            return PartiesListSentPartyInvitations(null);
        }

        /// <summary>
        /// Create a lobby with the party (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/create_lobby
        /// body: is_hidden, is_locked, max_users, metadata, password, title.
        /// </remarks>
        public Task<Response> PartiesPartyCreateLobby(JObject body)
        {
            var path = "/api/v1/parties/create_lobby";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Join a lobby with the party (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/join_lobby/{id}
        /// body: password.
        /// </remarks>
        public Task<Response> PartiesPartyJoinLobby(string id, JObject body)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("PartiesPartyJoinLobby", "id");
            var path = "/api/v1/parties/join_lobby/" + Query.Escape(id);
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Party counts
        /// </summary>
        /// <remarks>
        /// GET /api/v1/parties/stats
        /// </remarks>
        public Task<Response> PartiesPartyStats()
        {
            var path = "/api/v1/parties/stats";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Get current party
        /// </summary>
        /// <remarks>
        /// GET /api/v1/parties/me
        /// </remarks>
        public Task<Response> PartiesShowParty()
        {
            var path = "/api/v1/parties/me";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Update party settings (leader only)
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/parties
        /// body: max_size, metadata.
        /// </remarks>
        public Task<Response> PartiesUpdateParty(JObject body)
        {
            var path = "/api/v1/parties";
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        // Payments

        /// <summary>
        /// Receive App Store Server Notification v2 events
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/webhooks/apple
        /// </remarks>
        public Task<Response> PaymentsAppleWebhook(JObject body)
        {
            var path = "/api/v1/payments/webhooks/apple";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// List active payment catalog entries
        /// </summary>
        /// <remarks>
        /// GET /api/v1/payments/catalog
        /// options: provider, page, page_size.
        /// </remarks>
        public Task<Response> PaymentsCatalog(JObject options)
        {
            var path = "/api/v1/payments/catalog";
            path += Query.Build(options, "provider", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List active payment catalog entries
        /// </summary>
        public Task<Response> PaymentsCatalog()
        {
            return PaymentsCatalog(null);
        }

        /// <summary>
        /// List current user's active entitlements
        /// </summary>
        /// <remarks>
        /// GET /api/v1/payments/entitlements
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> PaymentsEntitlements(JObject options)
        {
            var path = "/api/v1/payments/entitlements";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List current user's active entitlements
        /// </summary>
        public Task<Response> PaymentsEntitlements()
        {
            return PaymentsEntitlements(null);
        }

        /// <summary>
        /// Receive Google Play RTDN Pub/Sub push events
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/webhooks/google
        /// </remarks>
        public Task<Response> PaymentsGoogleWebhook(JObject body)
        {
            var path = "/api/v1/payments/webhooks/google";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Create a Steam MicroTxn transaction
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/checkout/steam
        /// body: currency, ipaddress, language, product_sku, provider_product_id, quantity,
        /// steam_id, usersession.
        /// </remarks>
        public Task<Response> PaymentsSteamCheckout(JObject body)
        {
            var path = "/api/v1/payments/checkout/steam";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Finalize an authorized Steam MicroTxn transaction
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/steam/finalize
        /// body: order_id (required).
        /// </remarks>
        public Task<Response> PaymentsSteamFinalize(JObject body)
        {
            if (!Query.Given(body, "order_id")) return _rest.Refuse("PaymentsSteamFinalize", "order_id");
            var path = "/api/v1/payments/steam/finalize";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Create a Stripe Checkout Session
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/checkout/stripe
        /// body: cancel_url, product_sku, provider_product_id, quantity, success_url.
        /// </remarks>
        public Task<Response> PaymentsStripeCheckout(JObject body)
        {
            var path = "/api/v1/payments/checkout/stripe";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Receive Stripe webhook events
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/webhooks/stripe
        /// </remarks>
        public Task<Response> PaymentsStripeWebhook(JObject body)
        {
            var path = "/api/v1/payments/webhooks/stripe";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Validate an Apple, Google, or Steam purchase
        /// </summary>
        /// <remarks>
        /// POST /api/v1/payments/validate/{provider}
        /// </remarks>
        public Task<Response> PaymentsValidateStorePurchase(string provider, JObject body)
        {
            if (string.IsNullOrEmpty(provider)) return _rest.Refuse("PaymentsValidateStorePurchase", "provider");
            var path = "/api/v1/payments/validate/" + Query.Escape(provider);
            return _rest.Send("POST", path, Body.Of(body));
        }

        // Push

        /// <summary>
        /// Unregister one of the current user's devices
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/me/push_tokens/{id}
        /// </remarks>
        public Task<Response> PushDeletePushToken(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("PushDeletePushToken", "id");
            var path = "/api/v1/me/push_tokens/" + Query.Escape(id);
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// List the current user's registered devices
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/push_tokens
        /// options: page, page_size.
        /// </remarks>
        public Task<Response> PushListPushTokens(JObject options)
        {
            var path = "/api/v1/me/push_tokens";
            path += Query.Build(options, "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List the current user's registered devices
        /// </summary>
        public Task<Response> PushListPushTokens()
        {
            return PushListPushTokens(null);
        }

        /// <summary>
        /// Register a device push token
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/push_tokens
        /// body: token (required), platform (required), device_id, metadata, provider.
        /// </remarks>
        public Task<Response> PushRegisterPushToken(JObject body)
        {
            if (!Query.Given(body, "token")) return _rest.Refuse("PushRegisterPushToken", "token");
            if (!Query.Given(body, "platform")) return _rest.Refuse("PushRegisterPushToken", "platform");
            var path = "/api/v1/me/push_tokens";
            return _rest.Send("POST", path, Body.Of(body));
        }

        // Quests

        /// <summary>
        /// Claim a completed quest
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/quests/{key}/claim
        /// </remarks>
        public Task<Response> QuestsClaimQuest(string key)
        {
            if (string.IsNullOrEmpty(key)) return _rest.Refuse("QuestsClaimQuest", "key");
            var path = "/api/v1/me/quests/" + Query.Escape(key) + "/claim";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// List quests
        /// </summary>
        /// <remarks>
        /// GET /api/v1/quests
        /// options: category, page, page_size.
        /// </remarks>
        public Task<Response> QuestsListQuests(JObject options)
        {
            var path = "/api/v1/quests";
            path += Query.Build(options, "category", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List quests
        /// </summary>
        public Task<Response> QuestsListQuests()
        {
            return QuestsListQuests(null);
        }

        /// <summary>
        /// List quests a code can finish
        /// </summary>
        /// <remarks>
        /// GET /api/v1/quests/redeemable
        /// options: quest, page, page_size.
        /// </remarks>
        public Task<Response> QuestsListRedeemableQuests(JObject options)
        {
            var path = "/api/v1/quests/redeemable";
            path += Query.Build(options, "quest", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List quests a code can finish
        /// </summary>
        public Task<Response> QuestsListRedeemableQuests()
        {
            return QuestsListRedeemableQuests(null);
        }

        /// <summary>
        /// List my quests
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/quests
        /// options: category, group, page, page_size.
        /// </remarks>
        public Task<Response> QuestsMyQuests(JObject options)
        {
            var path = "/api/v1/me/quests";
            path += Query.Build(options, "category", "group", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List my quests
        /// </summary>
        public Task<Response> QuestsMyQuests()
        {
            return QuestsMyQuests(null);
        }

        /// <summary>
        /// Quest progress counts
        /// </summary>
        /// <remarks>
        /// GET /api/v1/quests/stats
        /// </remarks>
        public Task<Response> QuestsQuestStats()
        {
            var path = "/api/v1/quests/stats";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Redeem a code
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/quests/redeem
        /// body: token (required).
        /// </remarks>
        public Task<Response> QuestsRedeemQuestCode(JObject body)
        {
            if (!Query.Given(body, "token")) return _rest.Refuse("QuestsRedeemQuestCode", "token");
            var path = "/api/v1/me/quests/redeem";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// List a user's completed quests
        /// </summary>
        /// <remarks>
        /// GET /api/v1/quests/user/{user_id}
        /// options: category, page, page_size.
        /// </remarks>
        public Task<Response> QuestsUserQuests(string userId, JObject options)
        {
            if (string.IsNullOrEmpty(userId)) return _rest.Refuse("QuestsUserQuests", "user_id");
            var path = "/api/v1/quests/user/" + Query.Escape(userId);
            path += Query.Build(options, "category", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List a user's completed quests
        /// </summary>
        public Task<Response> QuestsUserQuests(string userId)
        {
            return QuestsUserQuests(userId, null);
        }

        // Ready checks

        /// <summary>
        /// Call off the ready check in the caller's lobby (host only)
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/lobbies/ready_check
        /// </remarks>
        public Task<Response> ReadyChecksCancelLobby()
        {
            var path = "/api/v1/lobbies/ready_check";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Call off the ready check in the caller's party (leader only)
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/parties/ready_check
        /// </remarks>
        public Task<Response> ReadyChecksCancelParty()
        {
            var path = "/api/v1/parties/ready_check";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// Get the caller's open ready checks
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me/ready_check
        /// </remarks>
        public Task<Response> ReadyChecksGetMine()
        {
            var path = "/api/v1/me/ready_check";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Open (or reset) the ready board in the caller's lobby (host only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/lobbies/ready_check
        /// body: metadata, timeout_ms.
        /// </remarks>
        public Task<Response> ReadyChecksOpenLobby(JObject body)
        {
            var path = "/api/v1/lobbies/ready_check";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Open (or reset) the ready board in the caller's party (leader only)
        /// </summary>
        /// <remarks>
        /// POST /api/v1/parties/ready_check
        /// body: metadata, timeout_ms.
        /// </remarks>
        public Task<Response> ReadyChecksOpenParty(JObject body)
        {
            var path = "/api/v1/parties/ready_check";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Answer one of the caller's open ready checks
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/ready_check
        /// body: ready (required), scope.
        /// </remarks>
        public Task<Response> ReadyChecksRespond(JObject body)
        {
            if (!Query.Given(body, "ready")) return _rest.Refuse("ReadyChecksRespond", "ready");
            var path = "/api/v1/me/ready_check";
            return _rest.Send("POST", path, Body.Of(body));
        }

        // Reports

        /// <summary>
        /// File a report
        /// </summary>
        /// <remarks>
        /// POST /api/v1/reports
        /// body: kind (required), attachments, client, data, description, email, locale,
        /// subject, topic.
        /// </remarks>
        public Task<Response> ReportsCreateReport(JObject body)
        {
            if (!Query.Given(body, "kind")) return _rest.Refuse("ReportsCreateReport", "kind");
            var path = "/api/v1/reports";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Report kinds
        /// </summary>
        /// <remarks>
        /// GET /api/v1/reports/kinds
        /// </remarks>
        public Task<Response> ReportsListReportKinds()
        {
            var path = "/api/v1/reports/kinds";
            return _rest.Send("GET", path, Body.None);
        }

        // Results

        /// <summary>
        /// Get a result
        /// </summary>
        /// <remarks>
        /// GET /api/v1/results/{id}
        /// </remarks>
        public Task<Response> ResultsGetResult(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ResultsGetResult", "id");
            var path = "/api/v1/results/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List a result's events
        /// </summary>
        /// <remarks>
        /// GET /api/v1/results/{id}/events
        /// options: after, limit.
        /// </remarks>
        public Task<Response> ResultsListResultEvents(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("ResultsListResultEvents", "id");
            var path = "/api/v1/results/" + Query.Escape(id) + "/events";
            path += Query.Build(options, "after", "limit");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List a result's events
        /// </summary>
        public Task<Response> ResultsListResultEvents(string id)
        {
            return ResultsListResultEvents(id, null);
        }

        /// <summary>
        /// List the caller's results
        /// </summary>
        /// <remarks>
        /// GET /api/v1/results
        /// options: kind, status, page, page_size.
        /// </remarks>
        public Task<Response> ResultsListResults(JObject options)
        {
            var path = "/api/v1/results";
            path += Query.Build(options, "kind", "status", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List the caller's results
        /// </summary>
        public Task<Response> ResultsListResults()
        {
            return ResultsListResults(null);
        }

        // Signaling

        /// <summary>
        /// WebRTC room counts
        /// </summary>
        /// <remarks>
        /// GET /api/v1/signaling/stats
        /// </remarks>
        public Task<Response> SignalingStats()
        {
            var path = "/api/v1/signaling/stats";
            return _rest.Send("GET", path, Body.None);
        }

        // Stats

        /// <summary>
        /// All public server counters in one call
        /// </summary>
        /// <remarks>
        /// GET /api/v1/stats
        /// </remarks>
        public Task<Response> StatsGetStats()
        {
            var path = "/api/v1/stats";
            return _rest.Send("GET", path, Body.None);
        }

        // Time

        /// <summary>
        /// Server clock
        /// </summary>
        /// <remarks>
        /// GET /api/v1/time
        /// </remarks>
        public Task<Response> TimeGetServerTime()
        {
            var path = "/api/v1/time";
            return _rest.Send("GET", path, Body.None);
        }

        // Tournaments

        /// <summary>
        /// Tournament details (with the caller's participation when authenticated)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/tournaments/{id}
        /// </remarks>
        public Task<Response> TournamentsGetTournament(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsGetTournament", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Register as an entry leader
        /// </summary>
        /// <remarks>
        /// POST /api/v1/tournaments/{id}/join
        /// </remarks>
        public Task<Response> TournamentsJoinTournament(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsJoinTournament", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id) + "/join";
            return _rest.Send("POST", path, Body.None);
        }

        /// <summary>
        /// Withdraw the caller's entry (before the draw)
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/tournaments/{id}/join
        /// </remarks>
        public Task<Response> TournamentsLeaveTournament(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsLeaveTournament", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id) + "/join";
            return _rest.Send("DELETE", path, Body.None);
        }

        /// <summary>
        /// List tournaments
        /// </summary>
        /// <remarks>
        /// GET /api/v1/tournaments
        /// options: state, slug, page, page_size.
        /// </remarks>
        public Task<Response> TournamentsListTournaments(JObject options)
        {
            var path = "/api/v1/tournaments";
            path += Query.Build(options, "state", "slug", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// List tournaments
        /// </summary>
        public Task<Response> TournamentsListTournaments()
        {
            return TournamentsListTournaments(null);
        }

        /// <summary>
        /// Brackets and their matches (paginated by bracket)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/tournaments/{id}/bracket
        /// options: index, page, page_size.
        /// </remarks>
        public Task<Response> TournamentsTournamentBracket(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsTournamentBracket", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id) + "/bracket";
            path += Query.Build(options, "index", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Brackets and their matches (paginated by bracket)
        /// </summary>
        public Task<Response> TournamentsTournamentBracket(string id)
        {
            return TournamentsTournamentBracket(id, null);
        }

        /// <summary>
        /// Registered entries (paginated)
        /// </summary>
        /// <remarks>
        /// GET /api/v1/tournaments/{id}/entries
        /// options: state, page, page_size.
        /// </remarks>
        public Task<Response> TournamentsTournamentEntries(string id, JObject options)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsTournamentEntries", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id) + "/entries";
            path += Query.Build(options, "state", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Registered entries (paginated)
        /// </summary>
        public Task<Response> TournamentsTournamentEntries(string id)
        {
            return TournamentsTournamentEntries(id, null);
        }

        /// <summary>
        /// The caller's current unresolved match
        /// </summary>
        /// <remarks>
        /// GET /api/v1/tournaments/{id}/my_match
        /// </remarks>
        public Task<Response> TournamentsTournamentMyMatch(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsTournamentMyMatch", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id) + "/my_match";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Placements, wins and champions
        /// </summary>
        /// <remarks>
        /// GET /api/v1/tournaments/{id}/standings
        /// </remarks>
        public Task<Response> TournamentsTournamentStandings(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("TournamentsTournamentStandings", "id");
            var path = "/api/v1/tournaments/" + Query.Escape(id) + "/standings";
            return _rest.Send("GET", path, Body.None);
        }

        // Users

        /// <summary>
        /// Request an avatar upload ticket
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/avatar/upload_url
        /// body: content_type (required), filename.
        /// </remarks>
        public Task<Response> UserCreateCurrentUserAvatarUploadUrl(JObject body)
        {
            if (!Query.Given(body, "content_type")) return _rest.Refuse("UserCreateCurrentUserAvatarUploadUrl", "content_type");
            var path = "/api/v1/me/avatar/upload_url";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Delete current user
        /// </summary>
        /// <remarks>
        /// DELETE /api/v1/me
        /// body: current_password.
        /// </remarks>
        public Task<Response> UserDeleteCurrentUser(JObject body)
        {
            var path = "/api/v1/me";
            return _rest.Send("DELETE", path, Body.Of(body));
        }

        /// <summary>
        /// Return current user info
        /// </summary>
        /// <remarks>
        /// GET /api/v1/me
        /// </remarks>
        public Task<Response> UsersGetCurrentUser()
        {
            var path = "/api/v1/me";
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Get a user by id
        /// </summary>
        /// <remarks>
        /// GET /api/v1/users/{id}
        /// </remarks>
        public Task<Response> UsersGetUser(string id)
        {
            if (string.IsNullOrEmpty(id)) return _rest.Refuse("UsersGetUser", "id");
            var path = "/api/v1/users/" + Query.Escape(id);
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Search users by id, username, or display_name
        /// </summary>
        /// <remarks>
        /// GET /api/v1/users
        /// options: q, page, page_size.
        /// </remarks>
        public Task<Response> UsersSearchUsers(JObject options)
        {
            var path = "/api/v1/users";
            path += Query.Build(options, "q", "page", "page_size");
            return _rest.Send("GET", path, Body.None);
        }

        /// <summary>
        /// Search users by id, username, or display_name
        /// </summary>
        public Task<Response> UsersSearchUsers()
        {
            return UsersSearchUsers(null);
        }

        /// <summary>
        /// Confirm an uploaded avatar
        /// </summary>
        /// <remarks>
        /// POST /api/v1/me/avatar
        /// body: key (required).
        /// </remarks>
        public Task<Response> UserSetCurrentUserAvatar(JObject body)
        {
            if (!Query.Given(body, "key")) return _rest.Refuse("UserSetCurrentUserAvatar", "key");
            var path = "/api/v1/me/avatar";
            return _rest.Send("POST", path, Body.Of(body));
        }

        /// <summary>
        /// Update current user's display name
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/me/display_name
        /// body: display_name (required).
        /// </remarks>
        public Task<Response> UserUpdateCurrentUserDisplayName(JObject body)
        {
            if (!Query.Given(body, "display_name")) return _rest.Refuse("UserUpdateCurrentUserDisplayName", "display_name");
            var path = "/api/v1/me/display_name";
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        /// <summary>
        /// Update current user password
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/me/password
        /// body: password (required), current_password.
        /// </remarks>
        public Task<Response> UserUpdateCurrentUserPassword(JObject body)
        {
            if (!Query.Given(body, "password")) return _rest.Refuse("UserUpdateCurrentUserPassword", "password");
            var path = "/api/v1/me/password";
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        /// <summary>
        /// Update current user's username
        /// </summary>
        /// <remarks>
        /// PATCH /api/v1/me/username
        /// body: username (required).
        /// </remarks>
        public Task<Response> UserUpdateCurrentUserUsername(JObject body)
        {
            if (!Query.Given(body, "username")) return _rest.Refuse("UserUpdateCurrentUserUsername", "username");
            var path = "/api/v1/me/username";
            return _rest.Send("PATCH", path, Body.Of(body));
        }

        /// <summary>
        /// Player counts
        /// </summary>
        /// <remarks>
        /// GET /api/v1/users/stats
        /// </remarks>
        public Task<Response> UserUserStats()
        {
            var path = "/api/v1/users/stats";
            return _rest.Send("GET", path, Body.None);
        }
    }
}
