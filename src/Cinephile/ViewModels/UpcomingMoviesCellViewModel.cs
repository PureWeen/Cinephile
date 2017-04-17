﻿using System;
using System.Linq;
using Cinephile.Core.Model;
using ReactiveUI;

namespace Cinephile.ViewModels
{
    public class UpcomingMoviesCellViewModel : ViewModelBase
    {
        public string Title
        {
            get
            {
                return this.movie.Title;
            }
        }

        public string PosterPath
        {
            get
            {
                return this.movie.PosterPath;
            }
        }

        public string Genres
        {
            get
            {
                return string.Join(", ", this.movie.Genres);
			}
        }

        private Movie movie;

        public UpcomingMoviesCellViewModel(Movie movie, IScreen hostScreen = null) : base(hostScreen)
        {
            this.movie = movie;
        }
    }
}