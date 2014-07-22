﻿using Microsoft.VisualStudio.Tools.Applications.Deployment;

namespace PowerPointLabs
{
    //Refer to:
    //http://msdn.microsoft.com/en-us/library/vstudio/dd465291(v=vs.100).aspx
    //Walkthrough: Copying a Document to the End User Computer after a ClickOnce Installation
    class PostInstall : IAddInPostDeploymentAction
    {
        public void Execute(AddInPostDeploymentActionArgs args)
        {
            const string sourceFile = TextCollection.QuickTutorialLink;

            switch (args.InstallationStatus)
            {
                case AddInInstallationStatus.InitialInstall:
                    try
                    {
                        System.Diagnostics.Process.Start("POWERPNT", sourceFile);
                    }
                    catch
                    {
                        //MessageBox.Show("Can't open");
                    }
                    break;
                case AddInInstallationStatus.Update:
                    break;
                case AddInInstallationStatus.Uninstall:
                    break;
            }
        }
    }
}
