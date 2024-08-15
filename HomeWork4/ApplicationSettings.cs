public class ApplicationSettings
{
    private string applicationName;
    public string ApplicationName
    {
        get { return applicationName; }
        set { ApplicationName = value; }
    }
    private string applicationVersion;
    public string ApplicationVersion
    {
        get { return applicationVersion; }
        set { ApplicationVersion = value; }
    }
    private string programLanguage;
    public string ProgramLanguage
    {
        get { return programLanguage; }
        set { ProgramLanguage = value; }
    }
    public class DatabaseSettings
    {
        private string connectionString;
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        private int connectionTimeout;
        public int ConnectionTimeout
        {
            get { return connectionTimeout; }
            set { connectionTimeout = value; }
        }
        public string GetDatabaseSettingsInfo()
        {
            return $"Connection String: {ConnectionString}\nConnection Timeout: {ConnectionTimeout} seconds";
        }
    }
    public DatabaseSettings DbSettings { get; set; }
    public ApplicationSettings()
    {
        DbSettings = new DatabaseSettings();
    }
    public string GetFullSettingsInfo()
    {
        return $"Application Name: {ApplicationName}\nVersion: {ApplicationVersion}\n" +
               $"Database Settings:\n{DbSettings.GetDatabaseSettingsInfo()}";
    }
}
