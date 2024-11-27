namespace WellnessApp {

    using Microsoft.Maui.Controls;
    using Syncfusion.Maui.DataForm;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class LoginFormBehavior : Behavior<ContentPage>
    {

        /// <summary>
        /// Holds the data form object.
        /// </summary>
        private SfDataForm? dataForm;

        /// <summary>
        /// Holds the login button instance.
        /// </summary>
        private Button? loginButton;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("loginForm");
            this.dataForm.GenerateDataFormItem += this.OnGenerateDataFormItem;

            this.loginButton = bindable.FindByName<Button>("loginButton");

            if (this.loginButton != null)
            {
                this.loginButton.Clicked += OnLoginButtonCliked;
            }
        }

        /// <summary>
        /// Invokes on each data form item generation.
        /// </summary>
        /// <param name="sender">The data form.</param>
        /// <param name="e">The event arguments.</param>
        private void OnGenerateDataFormItem(object? sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem is DataFormTextEditorItem textItem)
                {
                    // Customize the editor to set the text color to white
                    textItem.EditorTextStyle = new DataFormTextStyle { TextColor = Colors.White };

                    if (e.DataFormItem.FieldName == nameof(LoginFormModel.Email))
                    {
                        textItem.Keyboard = Keyboard.Email;
                    }
                    else if (e.DataFormItem.FieldName == nameof(LoginFormModel.Password))
                    {
                        textItem.Keyboard = Keyboard.Text; // or Keyboard.Default for password
                    }
                    else if (e.DataFormItem.FieldName == nameof(LoginFormModel.Email) ||
                             e.DataFormItem.FieldName == nameof(LoginFormModel.Password) ||
                            e.DataFormItem.FieldName == nameof(LoginFormModel.First_Name) ||
                             e.DataFormItem.FieldName == nameof(LoginFormModel.Last_Name) ||
                             e.DataFormItem.FieldName == nameof(LoginFormModel.dob))
                    {
                        textItem.Keyboard = Keyboard.Text;
                    }
                }
            }
        }

        /// <summary>
        /// Invokes on login button click.
        /// </summary>
        /// <param name="sender">The login button.</param>
        /// <param name="e">The event arguments.</param>
        private async void OnLoginButtonCliked(object? sender, EventArgs e)
        {
            if (this.dataForm != null && App.Current?.MainPage != null)
            {
                if (this.dataForm.Validate())
                {
                    await App.Current.MainPage.DisplayAlert("", "Signed in successfully", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("", "Please enter the required details", "OK");
                }
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.loginButton != null)
            {
                this.loginButton.Clicked -= OnLoginButtonCliked;
            }

            if (this.dataForm != null)
            {
                this.dataForm.GenerateDataFormItem -= this.OnGenerateDataFormItem;
            }
        }
    }
}

