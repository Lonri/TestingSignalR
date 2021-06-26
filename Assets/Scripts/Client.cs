using UnityEngine;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

public class Client: MonoBehaviour
{
	// Declaration the variables

	// SignalR variables
	//private static ClientWebSocket _Socket;
	private readonly Uri _Uri = new Uri("http://localhost:5000");
	private HubConnection _Connection;

	private async void Awake()
	{
		_Connection = new HubConnectionBuilder()
		.WithUrl(_Uri)
		.Build();
		await _Connection.StartAsync();
		// _Socket = new ClientWebSocket();
	}

	/*public async void OnClickStartConnection()
	{
		// await _Socket.ConnectAsync(_Uri, System.Threading.CancellationToken.None);
	}*/

	/*public async void CreateHamster() {
        Task result = _Connection.InvokeAsync("CreateHamster");
        await result;
        Debug.Log("RESULT: " + result);
    }*/


	private interface IClient
	{
		Task CreateHamster();
	}

}
