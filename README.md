# WpfMeetup_240425
WPF의 현대적 재해석 아발로니아
<br/>
<br/>
<br/>
## 설치 및 기본정리
### 1. 템플릿 설치
- 커맨드 열기
- 명령어 입력
```
dotnet new install Avalonia.Templates
```
### 2. 확장도구 설치 URL
- [VisualStudio](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaVS)
- [VisualCode](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.vscode-avalonia)

### 3. HotAvalonia [참고](https://github.com/Kir-Antipov/HotAvalonia)
**Nuget Install**
```
Avalonia.Markup.Xaml.Loader
HotAvalonia
HotAvalonia.Extensions 
```
**.csproj 파일에 추가**
```
<PropertyGroup Condition="'$(Configuration)' == 'Debug'">
  <DefineConstants>$(DefineConstants);ENABLE_XAML_HOT_RELOAD</DefineConstants>
</PropertyGroup>
```


### etc. VisualStudio Code 명령어 정리
- [Blog](https://blog.naver.com/lukewire129/223379542670)
  
<br/>
<br/>
<br/>

## Sample 소스
![Screenshot 2024-04-14 at 10 37 18](https://github.com/lukewire129/WpfMeetup_240425/assets/54387261/7863e977-4c5d-44b3-a192-2ce2a88f9321)

### WPF Sample
```
 <Window.Resources>
     <Style TargetType="{x:Type Button}">
         <Setter Property="HorizontalAlignment" Value="Center" />
         <Setter Property="VerticalAlignment" Value="Center" />
         <Setter Property="FontSize" Value="20" />
         <Setter Property="Background" Value="Transparent" />
         <Setter Property="Cursor" Value="Hand" />
         <Setter Property="Width" Value="200" />
         <Setter Property="Height" Value="100" />
         <Setter Property="Content" Value="Hello, WPF" />
         <Setter Property="Template">
             <Setter.Value>
                 <ControlTemplate TargetType="{x:Type Button}">
                     <Border
                         Background="{TemplateBinding Background}"
                         BorderBrush="Black"
                         BorderThickness="1"
                         CornerRadius="10">
                         <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center" />
                     </Border>
                     <ControlTemplate.Triggers>
                         <Trigger Property="IsMouseOver" Value="True">
                             <Setter Property="Background" Value="LightGray" />
                             <Setter Property="Foreground" Value="White" />
                         </Trigger>
                     </ControlTemplate.Triggers>
                 </ControlTemplate>
             </Setter.Value>
         </Setter>
     </Style>
 </Window.Resources>
 <Button />
```

## Avalonia Sample - ControlTheme
```
<Window.Resources>
    <ControlTheme x:Key="ButtonStyle" TargetType="{x:Type Button}">
        <Setter Property="HorizontalAlignment" Value="Center" />
        <Setter Property="VerticalAlignment" Value="Center" />
        <Setter Property="FontSize" Value="20" />
        <Setter Property="Background" Value="Transparent" />
        <Setter Property="Cursor" Value="Hand" />
        <Setter Property="Width" Value="200" />
        <Setter Property="Height" Value="100" />
        <Setter Property="Content" Value="Hello, Avalonia" />
        <Setter Property="Foreground" Value="Black" />
        <Setter Property="Template">
            <ControlTemplate>
                <Border
                    Background="{TemplateBinding Background}"
                    BorderBrush="Black"
                    BorderThickness="1"
                    CornerRadius="10">
                    <ContentPresenter
                        HorizontalAlignment="Center"
                        VerticalAlignment="Center"
                        Content="{TemplateBinding Content}" />
                </Border>
            </ControlTemplate>
        </Setter>
        <Style Selector="^:pointerover">
            <Setter Property="Background" Value="LightGray" />
            <Setter Property="Foreground" Value="White" />
        </Style>
    </ControlTheme>
</Window.Resources>
<Button Theme="{StaticResource ButtonStyle}" />
```

## Avalonia Sample - Style
```
<Window.Styles>
    <Style Selector="Button">
        <Setter Property="HorizontalAlignment" Value="Center" />
        <Setter Property="VerticalAlignment" Value="Center" />
        <Setter Property="FontSize" Value="20" />
        <Setter Property="Background" Value="Transparent" />
        <Setter Property="Cursor" Value="Hand" />
        <Setter Property="Width" Value="200" />
        <Setter Property="Height" Value="100" />
        <Setter Property="Content" Value="Hello, Avalonia" />
        <Setter Property="Foreground" Value="Black" />
        <Setter Property="Template">
            <ControlTemplate>
                <Border
                    Background="{TemplateBinding Background}"
                    BorderBrush="Black"
                    BorderThickness="1"
                    CornerRadius="10">
                    <ContentPresenter
                        HorizontalAlignment="Center"
                        VerticalAlignment="Center"
                        Content="{TemplateBinding Content}" />
                </Border>
            </ControlTemplate>
        </Setter>
        <Style Selector="^:pointerover">
            <Setter Property="Background" Value="LightGray" />
            <Setter Property="Foreground" Value="White" />
        </Style>
    </Style>
</Window.Styles>
<Button />
```
## Avalonia Sample - ControlTheme + Style
```
 <Window.Resources>
     <ControlTheme x:Key="ButtonStyle" TargetType="{x:Type Button}">
         <Setter Property="HorizontalAlignment" Value="Center" />
         <Setter Property="VerticalAlignment" Value="Center" />
         <Setter Property="FontSize" Value="20" />
         <Setter Property="Background" Value="Transparent" />
         <Setter Property="Cursor" Value="Hand" />
         <Setter Property="Width" Value="200" />
         <Setter Property="Height" Value="100" />
         <Setter Property="Content" Value="Hello, Avalonia" />
         <Setter Property="Foreground" Value="Black" />
         <Setter Property="Template">
             <ControlTemplate>
                 <Border
                     Background="{TemplateBinding Background}"
                     BorderBrush="Black"
                     BorderThickness="1"
                     CornerRadius="10">
                     <ContentPresenter
                         HorizontalAlignment="Center"
                         VerticalAlignment="Center"
                         Content="{TemplateBinding Content}" />
                 </Border>
             </ControlTemplate>
         </Setter>
     </ControlTheme>
 </Window.Resources>
 <Window.Styles>
     <Style Selector="Button:pointerover">
         <Setter Property="Background" Value="LightGray" />
         <Setter Property="Foreground" Value="White" />
     </Style>
 </Window.Styles>
 <Button Theme="{StaticResource ButtonStyle}" />
```
## Avalonia Sample - Style + Classes
```
 <Window.Styles>
     <Style Selector="Button.FontBold">
         <Setter Property="Foreground" Value="Red" />
     </Style>
     <Style Selector="Button.Size">
         <Setter Property="Width" Value="500" />
         <Setter Property="Height" Value="300" />
     </Style>
     <Style Selector="Button">
         <Setter Property="HorizontalAlignment" Value="Center" />
         <Setter Property="VerticalAlignment" Value="Center" />
         <Setter Property="FontSize" Value="20" />
         <Setter Property="Background" Value="Transparent" />
         <Setter Property="Cursor" Value="Hand" />
         <Setter Property="Width" Value="200" />
         <Setter Property="Height" Value="100" />
         <Setter Property="Content" Value="Hello, Avalonia" />
         <Setter Property="Foreground" Value="Black" />
         <Setter Property="Template">
             <ControlTemplate>
                 <Border
                     Background="{TemplateBinding Background}"
                     BorderBrush="Black"
                     BorderThickness="1"
                     CornerRadius="10">
                     <ContentPresenter
                         HorizontalAlignment="Center"
                         VerticalAlignment="Center"
                         Content="{TemplateBinding Content}" />
                 </Border>
             </ControlTemplate>
         </Setter>
         <Style Selector="^:pointerover">
             <Setter Property="Background" Value="LightGray" />
             <Setter Property="Foreground" Value="White" />
         </Style>
     </Style>
 </Window.Styles>
 <Button Classes="FontBold Size" />
```
