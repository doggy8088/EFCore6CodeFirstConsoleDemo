# 初始化專案

1. 檢查 .NET SDK 安裝版本是否包含 `6.0.315`

    ```sh
    dotnet --list-sdks
    ```

    ![image](https://user-images.githubusercontent.com/88981/258998984-f5d528c9-a428-432a-897d-41c0e0254bc0.png)

2. 準備一個空白資料夾，並鎖定 .NET SDK 版本

    ```sh
    dotnet new globaljson --sdk-version 6.0.100 --roll-forward latestFeature
    ```

    > 加上 `--roll-forward latestFeature` 參數會讓 .NET SDK 自動選用 .NET 6 的最新版！

3. 取得專案原始碼

    ```sh
    git clone https://github.com/doggy8088/EFCore6CodeFirstConsoleDemo.git
    cd EFCore6CodeFirstConsoleDemo
    ```

4. 還原 .NET 本地工具

    ```sh
    dotnet tool restore
    ```

5. 建立資料庫

    ```sh
    dotnet ef database update -v
    ```

6. 執行專案

    ```sh
    dotnet run
    ```

    或者也可透過以下命令執行並自動監視原始碼變更：

    ```sh
    dotnet watch run
    ```
