# Minecraft Skin Loader for DotNet (.NET)

## Basic usage

> ```
> public MinecraftSkin mcSkin;
>
> public void OnLoad(){
>  mcSkin = new MinecraftSkin(Data.username);
>  pictureBoxHead.Image = mcSkin.GetSkin(SkinType.Head);
> }
> ```
