using System.ComponentModel;

namespace TheBlogProject.Enumerations
{
    public enum ModerationType
    {
        //enumaration statuses - reference with ModerationType.Status; ex: ModerationType.Incomplete
        [Description("Proselytism")]
        Proselytism,
        [Description("Illegal Activity")]
        IllegalActivity,
        [Description("Harassment")]
        Harassment,
        [Description("Xenophobia")]
        Xenophobia,
        [Description("Commercial Spam")]
        Spam,
    }
}
