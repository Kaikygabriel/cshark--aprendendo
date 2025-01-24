# Acesse https://aka.ms/customizecontainer para saber como personalizar seu contêiner de depuração e como o Visual Studio usa este Dockerfile para criar suas imagens para uma depuração mais rápida.

# Dependendo do sistema operacional dos computadores host que compilarão ou executarão os contêineres, a imagem especificada na instrução FROM pode precisar ser alterada.
# Para obter mais informações, consulte https://aka.ms/containercompat.

# Esta fase é usada durante a execução no VS no modo rápido (Padrão para a configuração de Depuração)
FROM mcr.microsoft.com/dotnet/runtime:9.0-nanoserver-1809 AS base
WORKDIR /app


# Esta fase é usada para compilar o projeto de serviço
FROM mcr.microsoft.com/dotnet/sdk:9.0-windowsservercore-ltsc2019 AS build
# Instale Ferramentas de Build do Visual Studio. Elas são necessárias para publicação AOT
# Observação: o uso das Ferramentas de Build do Visual Studio requer uma licença válida do Visual Studio.
RUN curl -SL --output vs_buildtools.exe https://aka.ms/vs/17/release/vs_buildtools.exe
RUN vs_buildtools.exe --installPath C:\BuildTools --add Microsoft.VisualStudio.Component.VC.Tools.x86.x64 Microsoft.VisualStudio.Component.Windows10SDK.19041 --quiet --wait --norestart --nocache
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AddProduto/AddProduto.csproj", "AddProduto/"]
RUN dotnet restore "./AddProduto/AddProduto.csproj"
COPY . .
WORKDIR "/src/AddProduto"
RUN dotnet build "./AddProduto.csproj" -c %BUILD_CONFIGURATION% -o /app/build

# Esta fase é usada para publicar o projeto de serviço a ser copiado para a fase final
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AddProduto.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=true

# Esta fase é usada na produção ou quando executada no VS no modo normal (padrão quando não está usando a configuração de Depuração)
FROM mcr.microsoft.com/dotnet/runtime:9.0-nanoserver-1809 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["AddProduto.exe"]