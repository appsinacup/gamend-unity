// Written by clients/sdkgen (csharp) from the OpenAPI document.
// Do not edit; edit the generator or the spec and run
// clients/generate_csharp.sh.
//
// Every event a channel answers, one method each, from
// `clients/commands.json`. Each is a `Realtime.Push` with its topic and event
// filled in, and answers the same way:
//
//     var reply = await Commands.ResultsList(client.Realtime, new JObject { ["kind"] = "match" });
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Gamend
{
    /// <summary>Every event a channel answers, one method each.</summary>
    public static class Commands
    {
        /// <summary>
        /// call_hook on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: plugin (required), fn (required), args.
        /// </remarks>
        public static Task<Reply> CallHook(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "call_hook", parameters);
        }

        /// <summary>
        /// kv:subscribe on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: key (required), user_id, lobby_id.
        /// </remarks>
        public static Task<Reply> KvSubscribe(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "kv:subscribe", parameters);
        }

        /// <summary>
        /// kv:unsubscribe on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: key (required), user_id, lobby_id.
        /// </remarks>
        public static Task<Reply> KvUnsubscribe(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "kv:unsubscribe", parameters);
        }

        /// <summary>
        /// results:list on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: kind, status, page, page_size.
        /// </remarks>
        public static Task<Reply> ResultsList(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "results:list", parameters);
        }

        /// <summary>
        /// results:get on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: id (required).
        /// </remarks>
        public static Task<Reply> ResultsGet(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "results:get", parameters);
        }

        /// <summary>
        /// results:events on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: id (required), after, limit.
        /// </remarks>
        public static Task<Reply> ResultsEvents(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "results:events", parameters);
        }

        /// <summary>
        /// webrtc:offer on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: sdp (required), type.
        /// </remarks>
        public static Task<Reply> WebrtcOffer(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "webrtc:offer", parameters);
        }

        /// <summary>
        /// webrtc:ice on the user channel.
        /// </summary>
        /// <remarks>
        /// parameters: candidate (required), sdpMid, sdpMLineIndex.
        /// </remarks>
        public static Task<Reply> WebrtcIce(Realtime realtime, JObject parameters)
        {
            return realtime.Push(realtime.UserTopic, "webrtc:ice", parameters);
        }

        /// <summary>
        /// webrtc:close on the user channel.
        /// </summary>
        public static Task<Reply> WebrtcClose(Realtime realtime)
        {
            return realtime.Push(realtime.UserTopic, "webrtc:close", new JObject());
        }

        /// <summary>
        /// get_server_time on lobby:&lt;id&gt;.
        /// </summary>
        public static Task<Reply> LobbyGetServerTime(Realtime realtime, string id)
        {
            return realtime.Push("lobby:" + id, "get_server_time", new JObject());
        }

        /// <summary>
        /// offer on signaling:&lt;id&gt;.
        /// </summary>
        /// <remarks>
        /// parameters: target (required), sdp (required).
        /// </remarks>
        public static Task<Reply> SignalingOffer(Realtime realtime, string id, JObject parameters)
        {
            return realtime.Push("signaling:" + id, "offer", parameters);
        }

        /// <summary>
        /// answer on signaling:&lt;id&gt;.
        /// </summary>
        /// <remarks>
        /// parameters: target (required), sdp (required).
        /// </remarks>
        public static Task<Reply> SignalingAnswer(Realtime realtime, string id, JObject parameters)
        {
            return realtime.Push("signaling:" + id, "answer", parameters);
        }

        /// <summary>
        /// ice on signaling:&lt;id&gt;.
        /// </summary>
        /// <remarks>
        /// parameters: target (required), candidate (required).
        /// </remarks>
        public static Task<Reply> SignalingIce(Realtime realtime, string id, JObject parameters)
        {
            return realtime.Push("signaling:" + id, "ice", parameters);
        }

        /// <summary>
        /// broadcast_offer on signaling:&lt;id&gt;.
        /// </summary>
        /// <remarks>
        /// parameters: sdp (required).
        /// </remarks>
        public static Task<Reply> SignalingBroadcastOffer(Realtime realtime, string id, JObject parameters)
        {
            return realtime.Push("signaling:" + id, "broadcast_offer", parameters);
        }

        /// <summary>
        /// list_users on signaling:&lt;id&gt;.
        /// </summary>
        public static Task<Reply> SignalingListUsers(Realtime realtime, string id)
        {
            return realtime.Push("signaling:" + id, "list_users", new JObject());
        }
    }
}
