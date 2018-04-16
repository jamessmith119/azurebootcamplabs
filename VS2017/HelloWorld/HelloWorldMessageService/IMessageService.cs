using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport;
using System.Threading.Tasks;

[assembly: FabricTransportServiceRemotingProvider(
    RemotingListener = RemotingListener.V2Listener,
    RemotingClient = RemotingClient.V2Client,
    MaxMessageSize = 1073741824
)]
namespace HelloWorldMessageService
{
    public interface IMessageService : IService
    {
        Task<string> WriteMessage();
    }
}