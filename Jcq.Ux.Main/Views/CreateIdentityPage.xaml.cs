// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateIdentityPage.xaml.cs" company="Jan-Cornelius Molnar">
// The MIT License (MIT)
// 
// Copyright (c) 2015 Jan-Cornelius Molnar
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Windows;
using Jcq.Core;
using Jcq.Ux.ViewModel;

namespace Jcq.Ux.Main.Views
{
    public partial class CreateIdentityPage
    {
        public CreateIdentityPage()
        {
            ViewModel = new CreateIcqIdentityViewModel();

            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
        }

        public CreateIcqIdentityViewModel ViewModel { get; private set; }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewModel.NavigateToSignInPage();
            }
            catch (Exception ex)
            {
                Kernel.Exceptions.PublishException(ex);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string fullname;
            string uin;
            string password;

            try
            {
                fullname = txtName.Text;
                uin = txtUin.Text;
                password = txtPassword.Password;

                ViewModel.CreateIdentity(fullname, uin, password);
                ViewModel.NavigateToSignInPage();
            }
            catch (Exception ex)
            {
                Kernel.Exceptions.PublishException(ex);
            }
        }

        private void OnAddNewImageClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewModel.ImageSelector.AddImageFile();
            }
            catch (Exception ex)
            {
                Kernel.Exceptions.PublishException(ex);
            }
        }
    }
}