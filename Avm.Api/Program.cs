const string alanBeckerYouTube = "https://www.youtube.com/@alanbecker";

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => alanBeckerYouTube);
app.MapGet("/episode/{episodeNumber:int}", GetYouTubeUrl);

app.Run();

static string GetYouTubeUrl(int episodeNumber)
{
    var vidCode = episodeNumber switch
    {
        01 => "sVhWjSKywAQ",
        02 => "J_PRXuovweE",
        03 => "cPWPAjYb5eI",
        04 => "KXgaSaME-Ms",
        05 => "c9DrryMw248",
        06 => "y5zW1c30MGQ",
        07 => "z2sRTaa9lZU",
        08 => "E7x2pH6yiL4",
        09 => "_fPhQLM4Iac",
        10 => "wkedWWxRABM",
        11 => "WTPt07NO61A",
        12 => "O3JPzQYJTZk",
        13 => "zRD4-cl9_OU",
        14 => "pCBP4M08ndE",
        15 => "X7Mpp35EAqI",
        16 => "c0egcErkap0",
        17 => "WDQ60JGcxkw",
        18 => "ZXUCbK3Au4k",
        19 => "en5KyaRyRbw",
        20 => "H_4e85Q2EjE",
        21 => "-Y2Mi2iAVMY",
        22 => "q4dANhP7BVg",
        23 => "L_Z7lQTtJK8",
        24 => "yPCSUE0-4qI",
        25 => "8kiPjEeTaW4",
        26 => "YZ4W964hocA",
        27 => "SNuJrSP3JDA",
        28 => "o5RhbG3tOT8",
        29 => "4P6l35M61GY",
        30 => "Sp2nxlrQ89w",
        _ => string.Empty,
    };
    return vidCode is { Length: > 0 }
        ? $"https://www.youtube.com/watch?v={vidCode}"
        : alanBeckerYouTube;
}
