using System;
using Microsoft.Bot.Builder.FormFlow;

public enum MobileOptions { Laptop = 1, Smartphone, Tablet };
public enum ColorOptions { Black = 1, Silver, Gold, White, Red, Blue, Green };

[Serializable]
public class BasicForm
{
    [Prompt("Hello! What is your {&}?")]
    public string FullName { get; set; }

    [Prompt("Please select your favorite mobile device type {||}")]
    public MobileOptions MobileDevice { get; set; }

    [Prompt("Please select your favorite {&} {||}")]
    public ColorOptions Color { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        return FormDialog.FromForm(BuildForm, options);
    }
}
