# [JG] Dark+

A dark theme for Visual Studio Code. Based on the default [Dark+](https://github.com/Microsoft/vscode/blob/master/extensions/theme-defaults/themes/dark_plus.json) theme.

Makes only a few changes, mainly to make `C#` code more readable.

## Default vs [JG] Dark+

| Change                                |             Default Dark+ Theme               |          [JG] Dark+                                  |
|:------------------------------------- | --------------------------------------------- | ---------------------------------------------------- |
| More noticable regions                | ![regions_default](../img/jg-darkplus/regions_default.png)   | ![regions](../img/jg-darkplus/regions.png)     |
| Less noticable documentation comments | ![comments_default](../img/jg-darkplus/comments_default.png) | ![comments](../img/jg-darkplus/comments.png)   |

## Reasons

The default dark+ made C# code look very 'cluttered', at least to me. The multi-line documentation comments seemed way too colourful and felt a bit, out of place.

## Changes

If you want to know what exact changes I made, check out the [corresponding settings.json](templates/jg-darkplus/settings.json) file.

In there are the config changes I made, which override the default theme. After that, you can use the `Generate Color Theme From Current Settings` command in vscode (`Ctrl + Shift + P`) to compile a `color-theme.json` file.
