﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pupita.Domain.Dto
{
   public class AlbumDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid IdArtist { get; set; }
        public string ArtistName { get; set; }
        public List<TrackDto> Tracks { get; set; } = new List<TrackDto>();

    }
}
