namespace PersonLocations
{
    public class PersonLocations
    {
        public string PersonCode { get; set; }
        public string PersonRole { get; set; }
        public int LastSecurityPointNumber { get; set; }
        public string LastSecurityPointDirection { get; set; }
        public string LastSecurityPointTime { get; set; }

        public PersonLocations(string personCode, string personRole, int lastSecurityPointNumber, string lastSecurityPointDirection, string lastSecurityPointTime)
        {
            PersonCode = personCode;
            PersonRole = personRole;
            LastSecurityPointNumber = lastSecurityPointNumber;
            LastSecurityPointDirection = lastSecurityPointDirection;
            LastSecurityPointTime = lastSecurityPointTime;
        }
    }
}
