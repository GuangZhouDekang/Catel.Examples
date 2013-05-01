﻿namespace Catel.Examples.AdvancedDemo.Views
{
    using Catel.Windows;

    using ViewModels;

    /// <summary>
    /// Interaction logic for ThrottlingWindow.xaml.
    /// </summary>
    public partial class ThrottlingWindow : DataWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingWindow"/> class.
        /// </summary>
        public ThrottlingWindow()
            : this(null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingWindow"/> class.
        /// </summary>
        /// <param name="viewModel">The view model to inject.</param>
        /// <remarks>
        /// This constructor can be used to use view-model injection.
        /// </remarks>
        public ThrottlingWindow(ThrottlingViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
