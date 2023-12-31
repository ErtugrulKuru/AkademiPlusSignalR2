﻿using System.Threading.Tasks;
using AkademiPlusSignalR2.Models;
using Microsoft.AspNetCore.SignalR;

namespace AkademiPlusSignalR2.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorServices _visitorServices;

        public VisitorHub(VisitorServices visitorServices)
        {
            _visitorServices = visitorServices;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitorList",_visitorServices.GetVisitorChartList());
        }
    }
}
