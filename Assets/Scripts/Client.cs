using UnityEngine;
using System;
using Microsoft.AspNetCore.SignalR.Client;

public class Client: MonoBehaviour
{
	private readonly Uri _Uri = new Uri("http://localhost:5000");
	private HubConnection _Connection;

	private async void Awake()
	{
		_Connection = new HubConnectionBuilder()
		.WithUrl(_Uri)
		.Build();
		await _Connection.StartAsync();
	}
}
