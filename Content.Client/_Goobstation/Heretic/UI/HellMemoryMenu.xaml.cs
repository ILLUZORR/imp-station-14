using Content.Client.UserInterface.Controls;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._Goobstation.Heretic.UI;


[GenerateTypedNameReferences]
public sealed partial class HellMemoryMenu : FancyWindow
{
    public HellMemoryMenu()
    {
        RobustXamlLoader.Load(this);

        ConfirmButton.OnPressed += _ => Close();
    }
}
