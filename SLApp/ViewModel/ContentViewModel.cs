﻿using System.Collections.Generic;
using GalaSoft.MvvmLight;
using SLApp.Model;

namespace SLApp.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class ContentViewModel : ViewModelBase
    {
        private ServiceAgent _serviceAgent;

        /// <summary>
        /// Initializes a new instance of the ContentViewModel class.
        /// </summary>
        public ContentViewModel()
        {
            _serviceAgent = new ServiceAgent();
            _serviceAgent.GetContents(c => Contents = c);

            if (IsInDesignMode)
                SelContent = _contents[2];
        }

        private List<IContent> _contents;
        public List<IContent> Contents
        {
            get { return _contents; }
            set
            {
                _contents = value;
                RaisePropertyChanged("Contents");
            }
        }

        private IContent _selContent;
        public IContent SelContent
        {
            get { return _selContent; }
            set
            {
                _selContent = value;
                RaisePropertyChanged("SelContent");
            }
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean own resources if needed

        ////    base.Cleanup();
        ////}

    }
}