using System.Reactive.Disposables;
using Cinephile.ViewModels;
using ReactiveUI;

namespace Cinephile.Views
{
    public partial class MovieDetailView : ContentPageBase<MovieDetailViewModel>
    {
        public MovieDetailView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.PosterBig, x => x.Poster.Source, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, x => x.PosterSmall, x => x.Poster.LoadingPlaceholder, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, x => x.Genres, x => x.Genres.Text, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, x => x.ReleaseDate, x => x.ReleaseDate.Text, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, x => x.Overview, x => x.Overview.Text, x => x).DisposeWith(disposables);
            });
        }
    }
}
