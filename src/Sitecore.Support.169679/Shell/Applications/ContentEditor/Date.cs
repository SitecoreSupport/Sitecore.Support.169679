namespace Sitecore.Support.Shell.Applications.ContentEditor
{
  using System;
  public class Date : Sitecore.Shell.Applications.ContentEditor.Date
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