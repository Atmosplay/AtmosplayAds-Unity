using System;
using AtmosplayAds.Api;
using UnityEngine;

namespace AtmosplayAds.Common
{
    public interface IWindowAdClient
    {
        event EventHandler<EventArgs> OnAdLoaded;
        event EventHandler<AdFailedEventArgs> OnAdFailedToLoad;
        event EventHandler<EventArgs> OnAdStarted;
        event EventHandler<EventArgs> OnAdClicked;
        event EventHandler<EventArgs> OnAdFinished;
        event EventHandler<EventArgs> OnAdClosed;
        event EventHandler<EventArgs> OnAdFailToShow;


        bool IsReady();

        void Show(Transform windowAdRect, int windowAdAngle);

        void SetChannelId(string channelId);

        void Close();
    }
}