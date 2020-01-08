using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;

namespace AvaloniaMvvm.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private string _greeting = "[Name]";
        public string Greeting
        {
            get => _greeting;
            set => this.RaiseAndSetIfChanged(ref this._greeting, value);
        }
        

        private string _detail;
        public string Detail
        {
            get { return _detail; }
            set { this.RaiseAndSetIfChanged(ref this._detail, value); }
        }
        
        public ReactiveCommand<Unit, Unit> ButtonCommand { get; }
        

        public MainWindowViewModel()
        {
            ButtonCommand = ReactiveCommand.Create(ButtonAction);
        }
        
        

        private void ButtonAction()
        {
            Greeting = Detail;
        }
    }
}
