using System;
using System.Collections.Generic;
using System.Text;
using MonoTorrent.Tracker;

namespace MonoTorrent.Tracker
{
    public abstract class PeerEventArgs : EventArgs
    {
        private readonly Peer peer;
        private readonly SimpleTorrentManager torrent;

        public Peer Peer
        {
            get { return peer; }
        }

        public SimpleTorrentManager Torrent
        {
            get { return torrent; }
        }

        protected PeerEventArgs(Peer peer, SimpleTorrentManager torrent)
        {
            this.peer = peer;
            this.torrent = torrent;
        }
    }
}
