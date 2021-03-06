﻿using System.Collections.Generic;

namespace MVCMusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}