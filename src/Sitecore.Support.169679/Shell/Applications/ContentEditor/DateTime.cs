namespace Sitecore.Support.Shell.Applications.ContentEditor
{
  using System;
  public class DateTime : Sitecore.Shell.Applications.ContentEditor.DateTime
  {
    protected override void OnInit(EventArgs e)
    {
      #region Added code
      this.Disabled = this.ReadOnly; 
      #endregion
      base.OnInit(e);
    }
  }
}