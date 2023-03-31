using System.ComponentModel;
using System.Configuration;

namespace School_Project;

// Esta classe permite que você trate eventos específicos na classe de configurações:
//  O evento SettingChanging é gerado antes da alteração de um valor de configuração.
//  O evento PropertyChanged é gerado depois da alteração de um valor de configuração.
//  O evento SettingsLoaded é gerado depois do carregamento dos valores de configuração.
//  O evento SettingsSaving é gerado antes de salvar os valores de configuração.
internal sealed partial class WFormSettings
{
    private void SettingChangingEventHandler(object sender,
        SettingChangingEventArgs e)
    {
        // Adicione código para manipular o evento SettingChangingEvent aqui.
    }

    private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
    {
        // Adicione código para manipular o evento SettingsSaving aqui.
    }
}