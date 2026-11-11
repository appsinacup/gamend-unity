// Written by clients/sdkgen (csharp) from the OpenAPI document.
// Do not edit; edit the generator or the spec and run
// clients/generate_csharp.sh.
//
// A class for every schema the API answers with, read from a reply with
// `Response.As`:
//
//     var lobby = reply.As<Models.Lobby>();
//     var page = reply.Page<Models.Lobby>();
//
// A field the reply leaves out keeps its default; a nullable one is null; a
// free-form map stays `JToken`.
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Gamend.Models
{
    /// <summary>
    /// The account is banned: it can read and delete itself, every other call answers 403
    /// `account_banned`
    /// </summary>
    public sealed class AccountBan
    {
        /// <summary>
        /// When the ban ends; null for a permanent ban
        /// </summary>
        public string ExpiresAt { get; set; }
        /// <summary>
        /// Why, for the player; may be empty
        /// </summary>
        public string Reason { get; set; } = "";
    }

    /// <summary>
    /// Active and new player counts
    /// </summary>
    public sealed class ActivityStats
    {
        public long Dau { get; set; }
        public long Mau { get; set; }
        public long NewUsers1d { get; set; }
        public long NewUsers30d { get; set; }
        public long NewUsers7d { get; set; }
        public long Wau { get; set; }
    }

    /// <summary>
    /// A user as it appears in a member list
    /// </summary>
    public sealed class UserBrief
    {
        /// <summary>
        /// Chosen name
        /// </summary>
        public string DisplayName { get; set; } = "";
        public string Id { get; set; } = "";
        public bool IsActivated { get; set; }
        public bool IsOnline { get; set; }
        public string LastSeenAt { get; set; } = "";
        /// <summary>
        /// Public user metadata
        /// </summary>
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// The avatar: an image we host, or one of the server's icons
        /// (`/icons/&lt;name&gt;.svg?color=&lt;color&gt;`), one the user's id gives them when
        /// they set none
        /// </summary>
        public string ProfileUrl { get; set; } = "";
        /// <summary>
        /// Unique handle
        /// </summary>
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// A blocked friendship row
    /// </summary>
    public sealed class BlockedFriendship
    {
        /// <summary>
        /// The friendship row id
        /// </summary>
        public string Id { get; set; } = "";
        public UserBrief Requester { get; set; } = new UserBrief();
    }

    /// <summary>
    /// Rows cancelled; 0 when there was nothing to cancel
    /// </summary>
    public sealed class CancelledCount
    {
        public long Cancelled { get; set; }
    }

    /// <summary>
    /// A chat message
    /// </summary>
    public sealed class ChatMessage
    {
        /// <summary>
        /// The lobby, group or party id, or the friend's user id
        /// </summary>
        public string ChatRefId { get; set; } = "";
        public string ChatType { get; set; } = "";
        public string Content { get; set; } = "";
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Admin endpoints only
        /// </summary>
        public string SenderEmail { get; set; } = "";
        public string SenderId { get; set; } = "";
        /// <summary>
        /// Sender's display name
        /// </summary>
        public string SenderName { get; set; } = "";
        public string UpdatedAt { get; set; } = "";
    }

    /// <summary>
    /// A chat mute
    /// </summary>
    public sealed class ChatMuteRecord
    {
        /// <summary>
        /// Null for a mute with no end
        /// </summary>
        public string ExpiresAt { get; set; }
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        /// <summary>
        /// Who muted; empty for the system
        /// </summary>
        public string MutedBy { get; set; } = "";
        public string Reason { get; set; } = "";
        public string Scope { get; set; } = "";
        /// <summary>
        /// The lobby, group or party; empty when global
        /// </summary>
        public string ScopeRefId { get; set; } = "";
        /// <summary>
        /// The muted player
        /// </summary>
        public string UserId { get; set; } = "";
    }

    /// <summary>
    /// The last message read in a conversation
    /// </summary>
    public sealed class ChatReadCursor
    {
        public string ChatRefId { get; set; } = "";
        public string ChatType { get; set; } = "";
        public string LastReadMessageId { get; set; } = "";
        public string UpdatedAt { get; set; } = "";
    }

    /// <summary>
    /// Unread message count
    /// </summary>
    public sealed class ChatUnread
    {
        public long UnreadCount { get; set; }
    }

    /// <summary>
    /// A single client log entry
    /// </summary>
    public sealed class ClientLogEntry
    {
        /// <summary>
        /// Client clock, seconds since the Unix epoch.
        /// </summary>
        public double At { get; set; }
        /// <summary>
        /// Free-form subsystem tag owned by the game, e.g. game, network, perf.
        /// </summary>
        public string Category { get; set; } = "";
        /// <summary>
        /// Client level. Carried through as data; see the capture policy.
        /// </summary>
        public string Level { get; set; } = "";
        /// <summary>
        /// Lobby the client was in, if any. The join key to server-side lobby history.
        /// </summary>
        public string LobbyId { get; set; } = "";
        /// <summary>
        /// The line itself.
        /// </summary>
        public string Message { get; set; } = "";
        /// <summary>
        /// Where the player was, used to band a session into phases.
        /// </summary>
        public string Screen { get; set; } = "";
        /// <summary>
        /// Monotonic counter within the session. A gap tells the server entries were lost.
        /// </summary>
        public long Seq { get; set; }
    }

    /// <summary>
    /// Identity and environment of the client run
    /// </summary>
    public sealed class ClientLogSession
    {
        public string AppVersion { get; set; } = "";
        public string Build { get; set; } = "";
        /// <summary>
        /// Client-generated id, unique per run. Bound to the first caller that uses it; a later
        /// batch from a different user is refused.
        /// </summary>
        public string ClientSessionId { get; set; } = "";
        /// <summary>
        /// Stable device identifier.
        /// </summary>
        public string DeviceId { get; set; } = "";
        public string Locale { get; set; } = "";
        /// <summary>
        /// Free-form device facts: model, GPU, screen size. Capped server-side.
        /// </summary>
        public JToken Meta { get; set; } = JValue.CreateNull();
        public string Platform { get; set; } = "";
        /// <summary>
        /// When the run began, client clock, seconds since the Unix epoch.
        /// </summary>
        public double StartedAt { get; set; }
    }

    /// <summary>
    /// A batch of client log entries with the session they belong to
    /// </summary>
    public sealed class ClientLogBatch
    {
        /// <summary>
        /// At most 200 per call; the surplus is discarded and counted as dropped.
        /// </summary>
        public List<ClientLogEntry> Entries { get; set; } = new List<ClientLogEntry>();
        public ClientLogSession Session { get; set; } = new ClientLogSession();
    }

    /// <summary>
    /// Capture policy for game clients
    /// </summary>
    public sealed class ClientLogPolicy
    {
        /// <summary>
        /// Entries accepted per call.
        /// </summary>
        public long BatchMax { get; set; }
        /// <summary>
        /// Per-category overrides of the floor, e.g. {"perf": "off"}. off drops the category.
        /// </summary>
        public Dictionary<string, string> Categories { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Collect at all.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Lowest level to upload.
        /// </summary>
        public string Level { get; set; } = "";
        /// <summary>
        /// Longer messages are truncated server-side.
        /// </summary>
        public long MessageMaxBytes { get; set; }
    }

    /// <summary>
    /// Outcome of a client log upload
    /// </summary>
    public sealed class ClientLogResult
    {
        /// <summary>
        /// Entries recorded.
        /// </summary>
        public long Accepted { get; set; }
        public string ClientSessionId { get; set; } = "";
        /// <summary>
        /// Entries lost before or during this call.
        /// </summary>
        public long Dropped { get; set; }
        /// <summary>
        /// Error-level entries in this batch.
        /// </summary>
        public long Errors { get; set; }
    }

    /// <summary>
    /// Which sign-in methods are linked to the account
    /// </summary>
    public sealed class LinkedProviders
    {
        public bool Apple { get; set; }
        public bool Device { get; set; }
        public bool Discord { get; set; }
        public bool Facebook { get; set; }
        public bool Github { get; set; }
        public bool Google { get; set; }
        public bool Steam { get; set; }
    }

    /// <summary>
    /// The authenticated user
    /// </summary>
    public sealed class CurrentUser
    {
        /// <summary>
        /// The account's ban while it is banned, else null
        /// </summary>
        public AccountBan Ban { get; set; }
        /// <summary>
        /// Chosen name
        /// </summary>
        public string DisplayName { get; set; } = "";
        /// <summary>
        /// Empty for accounts without one
        /// </summary>
        public string Email { get; set; } = "";
        /// <summary>
        /// Whether a password is set
        /// </summary>
        public bool HasPassword { get; set; }
        public string Id { get; set; } = "";
        public bool IsOnline { get; set; }
        public string LastSeenAt { get; set; } = "";
        public LinkedProviders LinkedProviders { get; set; } = new LinkedProviders();
        /// <summary>
        /// Current lobby id, or empty
        /// </summary>
        public string LobbyId { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Current party id, or empty
        /// </summary>
        public string PartyId { get; set; } = "";
        /// <summary>
        /// The avatar: an image we host, or one of the server's icons
        /// (`/icons/&lt;name&gt;.svg?color=&lt;color&gt;`), one the user's id gives them when
        /// they set none
        /// </summary>
        public string ProfileUrl { get; set; } = "";
        /// <summary>
        /// Unique handle
        /// </summary>
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// Rows deleted
    /// </summary>
    public sealed class DeletedCount
    {
        public long Deleted { get; set; }
    }

    /// <summary>
    /// An owned entitlement
    /// </summary>
    public sealed class Entitlement
    {
        /// <summary>
        /// Null for a permanent entitlement
        /// </summary>
        public string ExpiresAt { get; set; }
        public string Id { get; set; } = "";
        /// <summary>
        /// What the game checks for
        /// </summary>
        public string Key { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Empty when not granted by a product
        /// </summary>
        public string ProductId { get; set; } = "";
        public string RevokedAt { get; set; }
        /// <summary>
        /// Empty when not granted by a purchase
        /// </summary>
        public string SourcePurchaseId { get; set; } = "";
        public string StartsAt { get; set; }
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// Error response
    /// </summary>
    public sealed class ErrorResponse
    {
        /// <summary>
        /// snake_case reason a client can switch on
        /// </summary>
        public string Error { get; set; } = "";
        /// <summary>
        /// With validation_failed only: per-field messages, already translated
        /// </summary>
        public Dictionary<string, List<string>> Errors { get; set; } = new Dictionary<string, List<string>>();
        /// <summary>
        /// A human-readable explanation
        /// </summary>
        public string Message { get; set; } = "";
    }

    /// <summary>
    /// An accepted friend
    /// </summary>
    public sealed class Friend
    {
        public string DisplayName { get; set; } = "";
        /// <summary>
        /// The friendship row: the id remove, block and unblock take
        /// </summary>
        public string FriendshipId { get; set; } = "";
        /// <summary>
        /// The friend's user id
        /// </summary>
        public string Id { get; set; } = "";
        public bool IsActivated { get; set; }
        public bool IsOnline { get; set; }
        public string LastSeenAt { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string ProfileUrl { get; set; } = "";
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// A friend request
    /// </summary>
    public sealed class FriendRequest
    {
        /// <summary>
        /// The friendship row id
        /// </summary>
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public UserBrief Requester { get; set; } = new UserBrief();
        public string Status { get; set; } = "";
        public UserBrief Target { get; set; } = new UserBrief();
    }

    /// <summary>
    /// Requests to and from the user
    /// </summary>
    public sealed class FriendRequestLists
    {
        public List<FriendRequest> Incoming { get; set; } = new List<FriendRequest>();
        public List<FriendRequest> Outgoing { get; set; } = new List<FriendRequest>();
    }

    /// <summary>
    /// Pagination for a list response
    /// </summary>
    public sealed class PageMeta
    {
        /// <summary>
        /// Rows on this page
        /// </summary>
        public long Count { get; set; }
        /// <summary>
        /// Whether a later page exists
        /// </summary>
        public bool HasMore { get; set; }
        /// <summary>
        /// This page, 1-based
        /// </summary>
        public long Page { get; set; }
        /// <summary>
        /// Rows asked for per page
        /// </summary>
        public long PageSize { get; set; }
        /// <summary>
        /// Rows across every page
        /// </summary>
        public long TotalCount { get; set; }
        /// <summary>
        /// Pages at this page size
        /// </summary>
        public long TotalPages { get; set; }
    }

    /// <summary>
    /// Pagination for each request list
    /// </summary>
    public sealed class FriendRequestMeta
    {
        public PageMeta Incoming { get; set; } = new PageMeta();
        public PageMeta Outgoing { get; set; } = new PageMeta();
    }

    /// <summary>
    /// A group
    /// </summary>
    public sealed class Group
    {
        /// <summary>
        /// Creator's user id; empty for a system group
        /// </summary>
        public string CreatorId { get; set; } = "";
        /// <summary>
        /// Creator's display name, or empty
        /// </summary>
        public string CreatorName { get; set; } = "";
        /// <summary>
        /// Empty when unset
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Empty when unset
        /// </summary>
        public string IconUrl { get; set; } = "";
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public long MaxMembers { get; set; }
        public long MemberCount { get; set; }
        /// <summary>
        /// Server-managed metadata
        /// </summary>
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Chat slowdown in seconds (0 = off)
        /// </summary>
        public long Slowdown { get; set; }
        /// <summary>
        /// Its name in a URL, unique per creator: lowercase letters and digits of any script
        /// joined by - or _
        /// </summary>
        public string Slug { get; set; } = "";
        /// <summary>
        /// Display title
        /// </summary>
        public string Title { get; set; } = "";
        /// <summary>
        /// Who may join and who may see it
        /// </summary>
        public string Type { get; set; } = "";
        public string UpdatedAt { get; set; } = "";
    }

    /// <summary>
    /// An invitation to join a group
    /// </summary>
    public sealed class GroupInvite
    {
        public string GroupId { get; set; } = "";
        public string GroupTitle { get; set; } = "";
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public string RecipientId { get; set; } = "";
        public string RecipientName { get; set; } = "";
        /// <summary>
        /// The recipient's avatar, as `sender_profile_url`
        /// </summary>
        public string RecipientProfileUrl { get; set; } = "";
        public string SenderId { get; set; } = "";
        public string SenderName { get; set; } = "";
        /// <summary>
        /// The sender's avatar: an image we host, or one of the server's icons
        /// (`/icons/&lt;name&gt;.svg?color=&lt;color&gt;`)
        /// </summary>
        public string SenderProfileUrl { get; set; } = "";
        /// <summary>
        /// pending | accepted | declined | cancelled
        /// </summary>
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// A group's invite link: anyone signed in who opens `url`, or joins with `token`, becomes
    /// a member
    /// </summary>
    public sealed class GroupInviteLink
    {
        public string ExpiresAt { get; set; } = "";
        public string GroupId { get; set; } = "";
        /// <summary>
        /// The link's secret part
        /// </summary>
        public string Token { get; set; } = "";
        /// <summary>
        /// The website page the link opens
        /// </summary>
        public string Url { get; set; } = "";
        /// <summary>
        /// How many people joined through it
        /// </summary>
        public long Uses { get; set; }
    }

    /// <summary>
    /// The group an invite link opens, and whether the caller is already in it
    /// </summary>
    public sealed class GroupInviteLinkPreview
    {
        /// <summary>
        /// The admin who made the link
        /// </summary>
        public string CreatorName { get; set; } = "";
        public string ExpiresAt { get; set; } = "";
        public string GroupId { get; set; } = "";
        public string GroupTitle { get; set; } = "";
        public string GroupType { get; set; } = "";
        /// <summary>
        /// Whether the caller is already a member
        /// </summary>
        public bool Member { get; set; }
        public long MemberCount { get; set; }
    }

    /// <summary>
    /// The result of an invitation
    /// </summary>
    public sealed class GroupInviteOutcome
    {
        /// <summary>
        /// `invited` when an invite was created, `request_approved` when the user had asked to
        /// join and was let in instead
        /// </summary>
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// A request to join a group
    /// </summary>
    public sealed class GroupJoinRequest
    {
        public string DisplayName { get; set; } = "";
        public string GroupId { get; set; } = "";
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public string Status { get; set; } = "";
        public string UserId { get; set; } = "";
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// A member of a group
    /// </summary>
    public sealed class GroupMember
    {
        public string DisplayName { get; set; } = "";
        public string GroupId { get; set; } = "";
        /// <summary>
        /// The membership row id
        /// </summary>
        public string Id { get; set; } = "";
        /// <summary>
        /// When they joined
        /// </summary>
        public string InsertedAt { get; set; } = "";
        public bool IsOnline { get; set; }
        public string LastSeenAt { get; set; } = "";
        /// <summary>
        /// The avatar: an image we host, or one of the server's icons
        /// (`/icons/&lt;name&gt;.svg?color=&lt;color&gt;`), one the user's id gives them when
        /// they set none. Empty when signed out
        /// </summary>
        public string ProfileUrl { get; set; } = "";
        public string Role { get; set; } = "";
        public string UserId { get; set; } = "";
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// The API is up
    /// </summary>
    public sealed class Health
    {
        /// <summary>
        /// Always `ok` when answered
        /// </summary>
        public string Status { get; set; } = "";
        /// <summary>
        /// The server's clock
        /// </summary>
        public string Timestamp { get; set; } = "";
    }

    /// <summary>
    /// A hook function at one arity
    /// </summary>
    public sealed class HookSignature
    {
        public long Arity { get; set; }
        /// <summary>
        /// Empty when undocumented
        /// </summary>
        public string Doc { get; set; } = "";
        /// <summary>
        /// A JSON array to start `args` from
        /// </summary>
        public string ExampleArgs { get; set; } = "";
        /// <summary>
        /// `fn_name(arg, ...)`
        /// </summary>
        public string Signature { get; set; } = "";
    }

    /// <summary>
    /// A callable hook function
    /// </summary>
    public sealed class HookFunction
    {
        public List<long> Arities { get; set; } = new List<long>();
        /// <summary>
        /// Registered at runtime rather than compiled
        /// </summary>
        public bool Dynamic { get; set; }
        /// <summary>
        /// The function name, as `call_hook` takes it
        /// </summary>
        public string Fn { get; set; } = "";
        /// <summary>
        /// A dynamic function's registration; `{}` otherwise
        /// </summary>
        public JToken Meta { get; set; } = JValue.CreateNull();
        public string Plugin { get; set; } = "";
        public List<HookSignature> Signatures { get; set; } = new List<HookSignature>();
    }

    /// <summary>
    /// Item code to quantity
    /// </summary>
    public sealed class Inventory : Dictionary<string, long>
    {
    }

    /// <summary>
    /// A key/value entry
    /// </summary>
    public sealed class KvEntry
    {
        /// <summary>
        /// The stored value
        /// </summary>
        public JToken Data { get; set; } = JValue.CreateNull();
        public string Key { get; set; } = "";
        /// <summary>
        /// Owning lobby; empty when not lobby-scoped
        /// </summary>
        public string LobbyId { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Owning user; empty when not user-scoped
        /// </summary>
        public string UserId { get; set; } = "";
    }

    /// <summary>
    /// A leaderboard (one season of a slug)
    /// </summary>
    public sealed class Leaderboard
    {
        public string Description { get; set; } = "";
        /// <summary>
        /// Null for a permanent leaderboard
        /// </summary>
        public string EndsAt { get; set; }
        /// <summary>
        /// Empty when unset (the client applies its own default)
        /// </summary>
        public string IconUrl { get; set; } = "";
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        /// <summary>
        /// Still accepting scores
        /// </summary>
        public bool IsActive { get; set; }
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// How a submitted score combines with the stored one
        /// </summary>
        public string Operator { get; set; } = "";
        /// <summary>
        /// Human-readable identifier in any script, shared by every season
        /// </summary>
        public string Slug { get; set; } = "";
        /// <summary>
        /// `desc`: higher is better; `asc`: lower is better
        /// </summary>
        public string SortOrder { get; set; } = "";
        public string StartsAt { get; set; }
        public string Title { get; set; } = "";
        public string UpdatedAt { get; set; } = "";
    }

    /// <summary>
    /// The keys the board holds listed records under
    /// </summary>
    public sealed class LeaderboardKeys
    {
        public List<string> Keys { get; set; } = new List<string>();
    }

    /// <summary>
    /// A ranked leaderboard record
    /// </summary>
    public sealed class LeaderboardRecord
    {
        /// <summary>
        /// The user's display name, or the label's text
        /// </summary>
        public string DisplayName { get; set; } = "";
        /// <summary>
        /// True on a guest's own record that the board does not list (the server requires an
        /// account to be listed): `rank` is where it would stand. Register to be listed.
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// Per-record metadata
        /// </summary>
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// 1 is the top of the board
        /// </summary>
        public long Rank { get; set; }
        public long Score { get; set; }
        public string UpdatedAt { get; set; } = "";
        /// <summary>
        /// Empty for a label record
        /// </summary>
        public string UserId { get; set; } = "";
        /// <summary>
        /// Empty for a label record
        /// </summary>
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// Slug to its active leaderboard; a slug with none is left out
    /// </summary>
    public sealed class LeaderboardsBySlug : Dictionary<string, Leaderboard>
    {
    }

    /// <summary>
    /// A wallet change
    /// </summary>
    public sealed class LedgerEntry
    {
        /// <summary>
        /// The balance right after this change
        /// </summary>
        public long BalanceAfter { get; set; }
        public string Currency { get; set; } = "";
        /// <summary>
        /// Positive for a grant, negative for a spend
        /// </summary>
        public long Delta { get; set; }
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Why, as the granting code named it
        /// </summary>
        public string Reason { get; set; } = "";
    }

    /// <summary>
    /// A lobby
    /// </summary>
    public sealed class Lobby
    {
        /// <summary>
        /// User id of the host; empty for a hostless lobby
        /// </summary>
        public string HostId { get; set; } = "";
        /// <summary>
        /// Display name of the host, or empty
        /// </summary>
        public string HostName { get; set; } = "";
        /// <summary>
        /// Server-managed, with no host
        /// </summary>
        public bool Hostless { get; set; }
        public string Id { get; set; } = "";
        /// <summary>
        /// Hidden from public listings
        /// </summary>
        public bool IsHidden { get; set; }
        /// <summary>
        /// Locked: no new joins
        /// </summary>
        public bool IsLocked { get; set; }
        /// <summary>
        /// Joining requires a password
        /// </summary>
        public bool IsPassworded { get; set; }
        /// <summary>
        /// Maximum number of users
        /// </summary>
        public long MaxUsers { get; set; }
        /// <summary>
        /// Current members
        /// </summary>
        public List<UserBrief> Members { get; set; } = new List<UserBrief>();
        /// <summary>
        /// Arbitrary metadata
        /// </summary>
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Chat slowdown in seconds (0 = off)
        /// </summary>
        public long Slowdown { get; set; }
        /// <summary>
        /// Current spectators
        /// </summary>
        public long SpectatorCount { get; set; }
        /// <summary>
        /// Lifecycle state in the game's vocabulary (core documents created, starting, playing,
        /// ended)
        /// </summary>
        public string State { get; set; } = "";
        /// <summary>
        /// When `state` last changed; null if it never has
        /// </summary>
        public string StateChangedAt { get; set; }
        /// <summary>
        /// Display title
        /// </summary>
        public string Title { get; set; } = "";
    }

    /// <summary>
    /// Lobby counts, cached for up to a minute
    /// </summary>
    public sealed class LobbyStats
    {
        /// <summary>
        /// Lobby count per lifecycle state
        /// </summary>
        public Dictionary<string, long> ByState { get; set; } = new Dictionary<string, long>();
        public long LobbiesTotal { get; set; }
        public long Spectators { get; set; }
    }

    /// <summary>
    /// Waiting players for one set of match params
    /// </summary>
    public sealed class MatchmakingQueue
    {
        public Dictionary<string, string> Params { get; set; } = new Dictionary<string, string>();
        public long Waiting { get; set; }
    }

    /// <summary>
    /// Players queued, overall and per match params, deepest first
    /// </summary>
    public sealed class MatchmakingStats
    {
        public long Queued { get; set; }
        public List<MatchmakingQueue> Queues { get; set; } = new List<MatchmakingQueue>();
    }

    /// <summary>
    /// A matchmaking ticket
    /// </summary>
    public sealed class MatchmakingTicket
    {
        public string Id { get; set; } = "";
        /// <summary>
        /// The lobby the ticket fills (its host queued from it, backfill); empty for none
        /// </summary>
        public string LobbyId { get; set; } = "";
        /// <summary>
        /// The lobby the ticket was matched into; empty while queued
        /// </summary>
        public string MatchId { get; set; } = "";
        /// <summary>
        /// String key/value pairs; only identical params match together
        /// </summary>
        public Dictionary<string, string> MatchParams { get; set; } = new Dictionary<string, string>();
        public string MatchedAt { get; set; }
        public long MaxPlayers { get; set; }
        public long MinPlayers { get; set; }
        public string QueuedAt { get; set; } = "";
        public string Status { get; set; } = "";
        public long TimeoutMs { get; set; }
    }

    /// <summary>
    /// A participant's answer
    /// </summary>
    public sealed class ReadyCheckParticipant
    {
        public string DisplayName { get; set; } = "";
        public string RespondedAt { get; set; }
        public string State { get; set; } = "";
        public string UserId { get; set; } = "";
    }

    /// <summary>
    /// A ready check
    /// </summary>
    public sealed class ReadyCheckState
    {
        /// <summary>
        /// Null for a board with no deadline
        /// </summary>
        public string DeadlineAt { get; set; }
        public string Id { get; set; } = "";
        public string Kind { get; set; } = "";
        /// <summary>
        /// Empty unless a lobby board
        /// </summary>
        public string LobbyId { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Empty when the server opened it
        /// </summary>
        public string OpenedBy { get; set; } = "";
        /// <summary>
        /// Only on kind `ready`: an accept check shows counts alone
        /// </summary>
        public List<ReadyCheckParticipant> Participants { get; set; } = new List<ReadyCheckParticipant>();
        /// <summary>
        /// Empty unless a party board
        /// </summary>
        public string PartyId { get; set; } = "";
        public long ReadyCount { get; set; }
        /// <summary>
        /// Why it failed: `declined`, `timeout` or `cancelled`; empty otherwise
        /// </summary>
        public string Reason { get; set; } = "";
        public string Status { get; set; } = "";
        public long Total { get; set; }
        /// <summary>
        /// The caller's own answer; empty when not a participant
        /// </summary>
        public string YourState { get; set; } = "";
    }

    /// <summary>
    /// The open check per lane; null where there is none
    /// </summary>
    public sealed class MyReadyChecks
    {
        /// <summary>
        /// The match lane: a lobby ready-up or a matchmaking accept
        /// </summary>
        public ReadyCheckState Lobby { get; set; }
        /// <summary>
        /// The party's standing ready board
        /// </summary>
        public ReadyCheckState Party { get; set; }
    }

    /// <summary>
    /// A notification
    /// </summary>
    public sealed class Notification
    {
        public string Content { get; set; } = "";
        /// <summary>
        /// The notification group it belongs to (`social`, `chat`, …). Empty for none
        /// </summary>
        public string Group { get; set; } = "";
        /// <summary>
        /// Empty when unset
        /// </summary>
        public string IconUrl { get; set; } = "";
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string RecipientId { get; set; } = "";
        /// <summary>
        /// Empty for a system notification
        /// </summary>
        public string SenderId { get; set; } = "";
        public string SenderName { get; set; } = "";
        public string Title { get; set; } = "";
    }

    /// <summary>
    /// A started OAuth sign-in
    /// </summary>
    public sealed class OAuthAuthorization
    {
        /// <summary>
        /// Open this for the player
        /// </summary>
        public string AuthorizationUrl { get; set; } = "";
        /// <summary>
        /// Poll `GET /auth/session/{session_id}` with it
        /// </summary>
        public string SessionId { get; set; } = "";
    }

    /// <summary>
    /// Tokens for a signed-in user
    /// </summary>
    public sealed class Session
    {
        /// <summary>
        /// JWT access token (15 min by default: `GAMEND_AUTH_ACCESS_TOKEN_TTL_MINUTES`)
        /// </summary>
        public string AccessToken { get; set; } = "";
        /// <summary>
        /// Chosen name
        /// </summary>
        public string DisplayName { get; set; } = "";
        /// <summary>
        /// Seconds until the access token expires
        /// </summary>
        public long ExpiresIn { get; set; }
        /// <summary>
        /// JWT refresh token (30 days by default: `GAMEND_AUTH_REFRESH_TOKEN_TTL_DAYS`)
        /// </summary>
        public string RefreshToken { get; set; } = "";
        public string UserId { get; set; } = "";
        /// <summary>
        /// Unique handle
        /// </summary>
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// Where a provider sign-in stands
    /// </summary>
    public sealed class OAuthSessionStatus
    {
        /// <summary>
        /// The code when `status` is `error` (`account_not_activated`, `sign_in_failed`,
        /// `authentication_failed`), else empty
        /// </summary>
        public string Error { get; set; } = "";
        /// <summary>
        /// For a person; may be empty
        /// </summary>
        public string Message { get; set; } = "";
        /// <summary>
        /// The signed-in session, on the first read after `completed`; null on every other
        /// </summary>
        public Session Session { get; set; }
        /// <summary>
        /// `pending` until the player finishes at the provider
        /// </summary>
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// The action succeeded
    /// </summary>
    public sealed class OkResponse
    {
        public bool Ok { get; set; }
    }

    /// <summary>
    /// A party
    /// </summary>
    public sealed class Party
    {
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public string LeaderId { get; set; } = "";
        /// <summary>
        /// Leader's display name
        /// </summary>
        public string LeaderName { get; set; } = "";
        /// <summary>
        /// Maximum members
        /// </summary>
        public long MaxSize { get; set; }
        public List<UserBrief> Members { get; set; } = new List<UserBrief>();
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string UpdatedAt { get; set; } = "";
    }

    /// <summary>
    /// An invitation to join a party
    /// </summary>
    public sealed class PartyInvite
    {
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public string PartyId { get; set; } = "";
        public string RecipientId { get; set; } = "";
        public string RecipientName { get; set; } = "";
        public string SenderId { get; set; } = "";
        public string SenderName { get; set; } = "";
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// Party counts, cached for up to a minute
    /// </summary>
    public sealed class PartyStats
    {
        public long PartiesActive { get; set; }
        public long PlayersInParties { get; set; }
    }

    /// <summary>
    /// A store product
    /// </summary>
    public sealed class PaymentProduct
    {
        public string Description { get; set; } = "";
        public string Id { get; set; } = "";
        /// <summary>
        /// What buying it grants, e.g. `entitlement`
        /// </summary>
        public string Kind { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string Sku { get; set; } = "";
        public string Title { get; set; } = "";
    }

    /// <summary>
    /// A product on one provider
    /// </summary>
    public sealed class PaymentCatalogEntry
    {
        /// <summary>
        /// Empty when the provider prices it
        /// </summary>
        public string Currency { get; set; } = "";
        /// <summary>
        /// The product's id at the provider
        /// </summary>
        public string ExternalId { get; set; } = "";
        public string Id { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public PaymentProduct Product { get; set; } = new PaymentProduct();
        /// <summary>
        /// `stripe`, `steam`, `apple` or `google`
        /// </summary>
        public string Provider { get; set; } = "";
        /// <summary>
        /// Price in the currency's minor unit; null when the provider prices it
        /// </summary>
        public long? UnitAmount { get; set; }
    }

    /// <summary>
    /// The event's outcome
    /// </summary>
    public sealed class PaymentWebhookReceipt
    {
        /// <summary>
        /// `ignored` for an event type the server does not act on
        /// </summary>
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// How many events a key has in a result, and the sum of their values
    /// </summary>
    public sealed class PlayResultStat
    {
        public long Count { get; set; }
        public double Sum { get; set; }
    }

    /// <summary>
    /// One play by one player, and its stats by event key
    /// </summary>
    public sealed class PlayResult
    {
        public string EndedAt { get; set; }
        public string Id { get; set; } = "";
        /// <summary>
        /// What was played
        /// </summary>
        public string Kind { get; set; } = "";
        /// <summary>
        /// The lobby it ran in; empty when none
        /// </summary>
        public string LobbyId { get; set; } = "";
        /// <summary>
        /// What the play was: its settings
        /// </summary>
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string StartedAt { get; set; } = "";
        /// <summary>
        /// By event key
        /// </summary>
        public Dictionary<string, PlayResultStat> Stats { get; set; } = new Dictionary<string, PlayResultStat>();
        public string Status { get; set; } = "";
        public string UserId { get; set; } = "";
        public string Visibility { get; set; } = "";
    }

    /// <summary>
    /// One thing that happened in a play; ids are time-ordered
    /// </summary>
    public sealed class PlayResultEvent
    {
        /// <summary>
        /// Milliseconds since the play began
        /// </summary>
        public long ElapsedMs { get; set; }
        public string Id { get; set; } = "";
        /// <summary>
        /// What happened
        /// </summary>
        public string Key { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string ResultId { get; set; } = "";
        public double? Value { get; set; }
    }

    /// <summary>
    /// A result's events, oldest first
    /// </summary>
    public sealed class PlayResultEvents
    {
        public List<PlayResultEvent> Events { get; set; } = new List<PlayResultEvent>();
        public string ResultId { get; set; } = "";
    }

    /// <summary>
    /// Player counts, cached for up to a minute
    /// </summary>
    public sealed class PlayerStats
    {
        public long PlayersInLobbies { get; set; }
        public long PlayersInParties { get; set; }
        public long PlayersOffline { get; set; }
        public long PlayersOnline { get; set; }
        public long PlayersTotal { get; set; }
    }

    /// <summary>
    /// Where a provider link stands
    /// </summary>
    public sealed class ProviderLinkStatus
    {
        /// <summary>
        /// The code when `status` is `error` (`provider_already_linked`, `link_failed`,
        /// `authentication_failed`), else empty
        /// </summary>
        public string Error { get; set; } = "";
        /// <summary>
        /// For a person; may be empty
        /// </summary>
        public string Message { get; set; } = "";
        /// <summary>
        /// The provider being linked
        /// </summary>
        public string Provider { get; set; } = "";
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// A user as anyone may see them
    /// </summary>
    public sealed class PublicUser
    {
        /// <summary>
        /// Chosen name
        /// </summary>
        public string DisplayName { get; set; } = "";
        public string Id { get; set; } = "";
        public bool IsActivated { get; set; }
        public bool IsOnline { get; set; }
        public string LastSeenAt { get; set; } = "";
        /// <summary>
        /// User metadata, restricted to the keys named by the :public_user_metadata_keys
        /// setting. Empty by default.
        /// </summary>
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Unique handle
        /// </summary>
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// A purchase
    /// </summary>
    public sealed class Purchase
    {
        /// <summary>
        /// Minor units; null when unknown
        /// </summary>
        public long? Amount { get; set; }
        public string Currency { get; set; } = "";
        /// <summary>
        /// `production` or a sandbox
        /// </summary>
        public string Environment { get; set; } = "";
        public string ExpiresAt { get; set; }
        public string Id { get; set; } = "";
        public string OrderId { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string Provider { get; set; } = "";
        /// <summary>
        /// Empty when not sold through the catalog
        /// </summary>
        public string ProviderProductId { get; set; } = "";
        /// <summary>
        /// Empty until the provider assigns one
        /// </summary>
        public string ProviderTransactionId { get; set; } = "";
        public string PurchasedAt { get; set; }
        public long Quantity { get; set; }
        public string RevokedAt { get; set; }
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// The validated purchase
    /// </summary>
    public sealed class PurchaseValidation
    {
        public Purchase Purchase { get; set; } = new Purchase();
        /// <summary>
        /// The receipt was already validated; nothing was granted again
        /// </summary>
        public bool SeenBefore { get; set; }
    }

    /// <summary>
    /// A device registered for push
    /// </summary>
    public sealed class PushToken
    {
        /// <summary>
        /// Empty when unset
        /// </summary>
        public string DeviceId { get; set; } = "";
        /// <summary>
        /// Set when the provider reported the token dead
        /// </summary>
        public string DisabledAt { get; set; }
        public string Id { get; set; } = "";
        public string InsertedAt { get; set; } = "";
        public string LastUsedAt { get; set; }
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string Platform { get; set; } = "";
        /// <summary>
        /// fcm or apns; empty picks by platform
        /// </summary>
        public string Provider { get; set; } = "";
        /// <summary>
        /// The provider's device token
        /// </summary>
        public string Token { get; set; } = "";
    }

    /// <summary>
    /// A quest objective
    /// </summary>
    public sealed class QuestObjective
    {
        /// <summary>
        /// Event name the objective counts
        /// </summary>
        public string Event { get; set; } = "";
        /// <summary>
        /// Event meta constraints (all must match)
        /// </summary>
        public JToken Params { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Occurrences required
        /// </summary>
        public long Target { get; set; }
    }

    /// <summary>
    /// Progress for the current reset period
    /// </summary>
    public sealed class QuestProgress
    {
        /// <summary>
        /// Finished runs of a repeat quest; 0 until the first claim
        /// </summary>
        public long ClaimCount { get; set; }
        public string ClaimedAt { get; set; }
        public string CompletedAt { get; set; }
        /// <summary>
        /// Objective index (as a string) to its current count
        /// </summary>
        public Dictionary<string, long> ObjectiveProgress { get; set; } = new Dictionary<string, long>();
        /// <summary>
        /// Reset bucket ("static", a date or an ISO week)
        /// </summary>
        public string PeriodKey { get; set; } = "";
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// A quest reward
    /// </summary>
    public sealed class QuestReward
    {
        /// <summary>
        /// Amount granted
        /// </summary>
        public long Amount { get; set; }
        /// <summary>
        /// Currency or item code
        /// </summary>
        public string Code { get; set; } = "";
        public string Type { get; set; } = "";
    }

    /// <summary>
    /// A quest, with the caller's progress
    /// </summary>
    public sealed class Quest
    {
        /// <summary>
        /// Rewards grant on completion
        /// </summary>
        public bool AutoClaim { get; set; }
        /// <summary>
        /// Free-form grouping label for your UI; empty when unset
        /// </summary>
        public string Category { get; set; } = "";
        /// <summary>
        /// Completed and waiting to be claimed
        /// </summary>
        public bool Claimable { get; set; }
        /// <summary>
        /// Only a redemption code finishes it (POST /me/quests/redeem)
        /// </summary>
        public bool CodeOnly { get; set; }
        public string Description { get; set; } = "";
        public string EndsAt { get; set; }
        /// <summary>
        /// Quests sharing this list as one entry; pass `?group=` to open it
        /// </summary>
        public string GroupKey { get; set; } = "";
        /// <summary>
        /// How many quests the entry stands for (1 when ungrouped)
        /// </summary>
        public long GroupSize { get; set; }
        /// <summary>
        /// The collapsed group entry's title
        /// </summary>
        public string GroupTitle { get; set; } = "";
        /// <summary>
        /// Hidden until completed
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// Empty when unset
        /// </summary>
        public string IconUrl { get; set; } = "";
        public string Id { get; set; } = "";
        /// <summary>
        /// Unique slug
        /// </summary>
        public string Key { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public List<QuestObjective> Objectives { get; set; } = new List<QuestObjective>();
        /// <summary>
        /// Quest that must be completed first; empty when none
        /// </summary>
        public string PrerequisiteQuestKey { get; set; } = "";
        /// <summary>
        /// Null when the caller has not started it, or is not signed in
        /// </summary>
        public QuestProgress Progress { get; set; }
        /// <summary>
        /// When progress starts over
        /// </summary>
        public string Reset { get; set; } = "";
        /// <summary>
        /// Cadence in days when `reset` is `interval` (biweekly = 14)
        /// </summary>
        public long? ResetIntervalDays { get; set; }
        public List<QuestReward> Rewards { get; set; } = new List<QuestReward>();
        public long SortOrder { get; set; }
        public string StartsAt { get; set; }
        public string Title { get; set; } = "";
    }

    /// <summary>
    /// A claimed quest's progress and the rewards granted
    /// </summary>
    public sealed class QuestClaim
    {
        public QuestProgress Progress { get; set; } = new QuestProgress();
        public List<QuestReward> Rewards { get; set; } = new List<QuestReward>();
    }

    /// <summary>
    /// Quest progress counts, cached for up to a minute
    /// </summary>
    public sealed class QuestStats
    {
        public long Claimed { get; set; }
        public long Completed { get; set; }
        public long QuestsTotal { get; set; }
    }

    /// <summary>
    /// An account just created with an email, waiting for it to be confirmed
    /// </summary>
    public sealed class Registration
    {
        /// <summary>
        /// Chosen name
        /// </summary>
        public string DisplayName { get; set; } = "";
        /// <summary>
        /// False: the account has no password until the emailed code confirms it (`POST
        /// /api/v1/register/confirm`), or the player opens the emailed link and sets one in
        /// their settings
        /// </summary>
        public bool EmailConfirmed { get; set; }
        public string UserId { get; set; } = "";
        /// <summary>
        /// Unique handle, generated when none was given
        /// </summary>
        public string Username { get; set; } = "";
    }

    /// <summary>
    /// What a report can be about, and what it may carry
    /// </summary>
    public sealed class ReportKind
    {
        /// <summary>
        /// The kind's key, sent as `kind`
        /// </summary>
        public string Key { get; set; } = "";
        /// <summary>
        /// Largest image, in bytes
        /// </summary>
        public long MaxAttachmentBytes { get; set; }
        /// <summary>
        /// Images a report may carry
        /// </summary>
        public long MaxAttachments { get; set; }
        /// <summary>
        /// Topics a report must pick one of; empty when the kind has none
        /// </summary>
        public List<string> Topics { get; set; } = new List<string>();
    }

    /// <summary>
    /// The report kinds
    /// </summary>
    public sealed class ReportKinds
    {
        public List<ReportKind> Kinds { get; set; } = new List<ReportKind>();
    }

    /// <summary>
    /// A filed report
    /// </summary>
    public sealed class ReportReceipt
    {
        /// <summary>
        /// Report id
        /// </summary>
        public string Id { get; set; } = "";
        public string Kind { get; set; } = "";
        public string Status { get; set; } = "";
    }

    /// <summary>
    /// A report about the game's content
    /// </summary>
    public sealed class ReportRequest
    {
        /// <summary>
        /// Base64 PNG, JPEG or WebP images, up to the kind's max_attachments
        /// </summary>
        public List<string> Attachments { get; set; } = new List<string>();
        /// <summary>
        /// Short device facts: user_agent, viewport, screen, platform, app_version
        /// </summary>
        public Dictionary<string, string> Client { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// The kind's extra fields (a suggested correction)
        /// </summary>
        public JToken Data { get; set; } = JValue.CreateNull();
        /// <summary>
        /// What happened
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Where to send a reply, if anywhere
        /// </summary>
        public string Email { get; set; } = "";
        /// <summary>
        /// A key from GET /reports/kinds
        /// </summary>
        public string Kind { get; set; } = "";
        public string Locale { get; set; } = "";
        /// <summary>
        /// What is reported, in the kind's own shape
        /// </summary>
        public JToken Subject { get; set; } = JValue.CreateNull();
        /// <summary>
        /// One of the kind's topics, if it has any
        /// </summary>
        public string Topic { get; set; } = "";
    }

    /// <summary>
    /// WebRTC room counts, cached for up to a minute
    /// </summary>
    public sealed class SignalingStats
    {
        public long PeersConnected { get; set; }
        /// <summary>
        /// Of those, with someone connected
        /// </summary>
        public long RoomsActive { get; set; }
        /// <summary>
        /// Lobbies with WebRTC on
        /// </summary>
        public long RoomsEnabled { get; set; }
    }

    /// <summary>
    /// Tournament match counts
    /// </summary>
    public sealed class TournamentMatchCounts
    {
        public long Open { get; set; }
        public long Overdue { get; set; }
        public long Total { get; set; }
    }

    /// <summary>
    /// Tournaments and entries per state, and match counts
    /// </summary>
    public sealed class TournamentStats
    {
        /// <summary>
        /// Entry count per state
        /// </summary>
        public Dictionary<string, long> Entries { get; set; } = new Dictionary<string, long>();
        public TournamentMatchCounts Matches { get; set; } = new TournamentMatchCounts();
        /// <summary>
        /// Tournament count per state
        /// </summary>
        public Dictionary<string, long> Tournaments { get; set; } = new Dictionary<string, long>();
    }

    /// <summary>
    /// All public server counters, cached for up to a minute
    /// </summary>
    public sealed class ServerStats
    {
        public ActivityStats Activity { get; set; } = new ActivityStats();
        public LobbyStats Lobbies { get; set; } = new LobbyStats();
        public MatchmakingStats Matchmaking { get; set; } = new MatchmakingStats();
        public PartyStats Parties { get; set; } = new PartyStats();
        public PlayerStats Players { get; set; } = new PlayerStats();
        public QuestStats Quests { get; set; } = new QuestStats();
        public SignalingStats Signaling { get; set; } = new SignalingStats();
        public TournamentStats Tournaments { get; set; } = new TournamentStats();
    }

    /// <summary>
    /// The server's clock
    /// </summary>
    public sealed class ServerTime
    {
        /// <summary>
        /// Milliseconds since the Unix epoch
        /// </summary>
        public long ServerNow { get; set; }
    }

    /// <summary>
    /// A pending purchase and its Steam transaction
    /// </summary>
    public sealed class SteamCheckout
    {
        public string ProviderTransactionId { get; set; } = "";
        public Purchase Purchase { get; set; } = new Purchase();
        /// <summary>
        /// Empty when Steam gave none
        /// </summary>
        public string SteamUrl { get; set; } = "";
    }

    /// <summary>
    /// A pending purchase and the Stripe page that pays it
    /// </summary>
    public sealed class StripeCheckout
    {
        public string CheckoutUrl { get; set; } = "";
        public string ProviderSessionId { get; set; } = "";
        public Purchase Purchase { get; set; } = new Purchase();
    }

    /// <summary>
    /// An entry in a tournament
    /// </summary>
    public sealed class TournamentEntry
    {
        /// <summary>
        /// Null until the draw
        /// </summary>
        public long? BracketIndex { get; set; }
        public string Id { get; set; } = "";
        public string LeaderId { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// Null until the draw
        /// </summary>
        public long? Seed { get; set; }
        public string State { get; set; } = "";
        public long Wins { get; set; }
    }

    /// <summary>
    /// A tournament occurrence
    /// </summary>
    public sealed class Tournament
    {
        public long BracketSize { get; set; }
        public string Description { get; set; } = "";
        public string EndsAt { get; set; }
        public long EntryCount { get; set; }
        /// <summary>
        /// Empty when unset (the client applies its own default)
        /// </summary>
        public string IconUrl { get; set; } = "";
        public string Id { get; set; } = "";
        /// <summary>
        /// Null for no cap
        /// </summary>
        public long? MaxEntries { get; set; }
        public JToken Metadata { get; set; } = JValue.CreateNull();
        /// <summary>
        /// The caller's entry. Only `GET /tournaments/{id}` sends it; null when the caller has
        /// none or is not signed in.
        /// </summary>
        public TournamentEntry MyEntry { get; set; }
        /// <summary>
        /// Cron expression; empty for a one-shot
        /// </summary>
        public string Recur { get; set; } = "";
        public string RegistrationOpensAt { get; set; }
        public long RoundWindowSec { get; set; }
        /// <summary>
        /// In any script, shared by every recurring occurrence
        /// </summary>
        public string Slug { get; set; } = "";
        /// <summary>
        /// Null when an admin starts it by hand
        /// </summary>
        public string StartsAt { get; set; }
        public string State { get; set; } = "";
        /// <summary>
        /// Advisory; enforced by game hooks
        /// </summary>
        public long TeamSize { get; set; }
        public string Title { get; set; } = "";
    }

    /// <summary>
    /// A match between two entries
    /// </summary>
    public sealed class TournamentMatch
    {
        /// <summary>
        /// Empty until the slot is filled
        /// </summary>
        public string AEntryId { get; set; } = "";
        /// <summary>
        /// Empty until the slot is filled
        /// </summary>
        public string ALeaderId { get; set; } = "";
        /// <summary>
        /// Empty until the slot is filled
        /// </summary>
        public string BEntryId { get; set; } = "";
        /// <summary>
        /// Empty until the slot is filled
        /// </summary>
        public string BLeaderId { get; set; } = "";
        public long BracketIndex { get; set; }
        public string DeadlineAt { get; set; }
        public string Id { get; set; } = "";
        public JToken Metadata { get; set; } = JValue.CreateNull();
        public string ResolvedAt { get; set; }
        /// <summary>
        /// 1 is the first round
        /// </summary>
        public long Round { get; set; }
        /// <summary>
        /// Position within the round
        /// </summary>
        public long Slot { get; set; }
        /// <summary>
        /// Empty until decided
        /// </summary>
        public string WinnerEntryId { get; set; } = "";
    }

    /// <summary>
    /// A bracket, its matches and their entries
    /// </summary>
    public sealed class TournamentBracket
    {
        /// <summary>
        /// The entries appearing in `matches`
        /// </summary>
        public List<TournamentEntry> Entries { get; set; } = new List<TournamentEntry>();
        public long Index { get; set; }
        /// <summary>
        /// By round, then slot
        /// </summary>
        public List<TournamentMatch> Matches { get; set; } = new List<TournamentMatch>();
        /// <summary>
        /// Entries the bracket seats
        /// </summary>
        public long Size { get; set; }
    }

    /// <summary>
    /// An entry's placement: winners first, then by wins
    /// </summary>
    public sealed class TournamentPlacement
    {
        public long? BracketIndex { get; set; }
        public string EntryId { get; set; } = "";
        public string LeaderId { get; set; } = "";
        /// <summary>
        /// 1 is first
        /// </summary>
        public long Placement { get; set; }
        public string State { get; set; } = "";
        public long Wins { get; set; }
    }

    /// <summary>
    /// Champions (one per bracket once decided) and every placement
    /// </summary>
    public sealed class TournamentStandings
    {
        public List<TournamentEntry> Champions { get; set; } = new List<TournamentEntry>();
        public List<TournamentPlacement> Placements { get; set; } = new List<TournamentPlacement>();
    }

    /// <summary>
    /// Where and how to upload an object
    /// </summary>
    public sealed class UploadTicket
    {
        /// <summary>
        /// Seconds the ticket stays valid
        /// </summary>
        public long ExpiresIn { get; set; }
        /// <summary>
        /// Headers the upload must carry
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// The object key to confirm afterwards
        /// </summary>
        public string Key { get; set; } = "";
        /// <summary>
        /// HTTP method, always PUT
        /// </summary>
        public string Method { get; set; } = "";
        /// <summary>
        /// Local storage only: the signed upload token, also carried in `url`
        /// </summary>
        public string Token { get; set; } = "";
        /// <summary>
        /// Where to send the bytes
        /// </summary>
        public string Url { get; set; } = "";
    }

    /// <summary>
    /// Currency code to balance
    /// </summary>
    public sealed class WalletBalances : Dictionary<string, long>
    {
    }

    /// <summary>A page of a list: the items, and where they sit in the whole.</summary>
    public sealed class Page<T>
    {
        public List<T> Data { get; set; } = new List<T>();
        public PageMeta Meta { get; set; } = new PageMeta();
    }
}
