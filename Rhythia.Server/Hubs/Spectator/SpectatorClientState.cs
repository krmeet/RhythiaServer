namespace Rhythia.Server.Hubs.Spectator;

public class SpectatorClientState : ClientState
{
    public SpectatorClientState(in string connectionId, in int userId) : base(connectionId, userId)
    {}
}