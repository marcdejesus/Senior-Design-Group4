namespace WellnessApp{
    public class DataFormViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataFormViewModel" /> class.
        /// </summary>
        public DataFormViewModel()
        {
            this.LoginFormModel = new LoginFormModel
            {
                Email = string.Empty,
                Password = string.Empty,
                First_Name = string.Empty,
                Last_Name = string.Empty,
                dob = string.Empty
            };
        }

        /// <summary>
        /// Gets or sets the login form model.
        /// </summary>
        public LoginFormModel LoginFormModel { get; set; }
    }
}