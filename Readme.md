# 🚀 Jogo da Nave (Unity 2D)

Um jogo arcade feito com Unity onde você controla uma nave e desvia de asteroides, acumulando pontuação com o tempo.

## 🎮 Gameplay

- Mova a nave horizontalmente para desviar dos asteroides
- Estrelas animadas no fundo criam a sensação de movimento espacial
- Colisões geram uma explosão e encerram a partida
- Tela de Game Over com pontuação final
- Tela de início com botão “Jogar”
- Compatível com Android (.apk incluído via Release)

## 🛠 Tecnologias

- **Unity 2D**
- **C#**
- **TextMeshPro**
- Sistema de animações (explosão)
- UI básica com navegação entre cenas
- Build para Android (APK)

## 📂 Estrutura

```
Assets/
├── Scenes/          # Main, GameOver, MainMenu
├── Scripts/         # Movimento, colisões, pontuação, controle de UI
├── Prefabs/         # Nave, asteroide, estrela, explosão
├── Sprites/         # Todos os gráficos do jogo
├── Animations/      # Animações da explosão
```

## 📦 Build (APK)

O projeto está pronto para exportação Android.

### Gerando o APK:

1. Vá em **File > Build Settings** ou **Build Profiles**
2. Selecione **Android** e clique em **Switch Platform** (se necessário)
3. Clique em **Build**, escolha um local e gere o arquivo `.apk`

### 📥 Baixar APK

Você pode baixar a versão mais recente do jogo diretamente pela seção de [Releases](https://github.com/GadiegoN/JogoDaNave/releases).

## 🧪 Instalação

### Android

1. Baixe o arquivo APK na seção de releases
2. Transfira para seu celular Android
3. Ative **Fontes desconhecidas** nas configurações do dispositivo
4. Instale e jogue 🎮

### Unity

1. Clone o repositório:

```bash
git clone https://github.com/GadiegoN/JogoDaNave.git
```

2. Abra o projeto no Unity Hub
3. Inicie a cena `MainMenu` para jogar

## 🧑‍💻 Contribuindo

Contribuições são bem-vindas!

1. Faça um fork do repositório
2. Crie uma branch: `git checkout -b minha-feature`
3. Commit: `git commit -m 'Adiciona nova feature'`
4. Push: `git push origin minha-feature`
5. Abra um Pull Request
