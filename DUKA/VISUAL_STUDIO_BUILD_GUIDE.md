# Visual Studio Build Guide - DUKA Project

## 🚨 Lỗi "Debug target is missing"

Nếu bạn gặp lỗi:
```
Visual Studio cannot start debugging because the debug target
'C:\CNPM_SANBONG\DUKA\GUI\bin\Debug\GUI.exe' is missing.
Please build the project and retry, or set the OutputPath and
AssemblyName properties appropriately to point at the correct
location for the target assembly.
```

## ✅ Giải pháp từng bước:

### Bước 1: Mở Solution trong Visual Studio
1. **File → Open → Project/Solution**
2. Chọn file `DUKA.sln` trong thư mục `C:\CNPM_SANBONG\DUKA\`
3. Chờ Visual Studio load solution

### Bước 2: Kiểm tra Configuration
1. Ở thanh toolbar, kiểm tra:
   - **Configuration**: `Debug` ✓
   - **Platform**: `Any CPU` hoặc `x64` ✓
2. Nếu không đúng, click vào dropdown và chọn lại

### Bước 3: Clean Solution
1. **Build → Clean Solution** (hoặc `Ctrl + Shift + B` nhưng chọn Clean)
2. Chờ process hoàn thành

### Bước 4: Rebuild Solution
1. **Build → Rebuild Solution** (hoặc `Ctrl + Shift + B`)
2. **Quan sát Output Window** để xem có lỗi không

### Bước 5: Kiểm tra References
Nếu build thất bại với lỗi "BUS_User could not be found":

1. **Right-click GUI project** → **Add → Reference**
2. Click tab **Browse**
3. Navigate đến:
   ```
   C:\CNPM_SANBONG\DUKA\DTO\bin\Debug\DTO.dll
   C:\CNPM_SANBONG\DUKA\DAL\bin\Debug\DAL.dll
   C:\CNPM_SANBONG\DUKA\BUS\bin\Debug\BUS.dll
   ```
4. Click **Add** cho cả 3 file DLL
5. **Rebuild** lại

### Bước 6: Build Order (quan trọng!)
Visual Studio cần build theo thứ tự đúng:

1. **DTO** (không phụ thuộc gì)
2. **DAL** (phụ thuộc DTO)
3. **BUS** (phụ thuộc DTO + DAL)
4. **GUI** (phụ thuộc cả 3)

Nếu build từng project một:
- Right-click **DTO** → **Build**
- Right-click **DAL** → **Build**
- Right-click **BUS** → **Build**
- Right-click **GUI** → **Build**

### Bước 7: Kiểm tra file exe
Sau khi build thành công:

1. Mở **Solution Explorer**
2. Expand **GUI → bin → Debug**
3. Kiểm tra có file `GUI.exe` không

### Bước 8: Chạy ứng dụng
1. **F5** hoặc **Debug → Start Debugging**
2. Ứng dụng sẽ khởi động với MainMenu

## 🔍 Debug Tips

### Nếu vẫn không build được:

1. **Restart Visual Studio**
   - Đóng và mở lại VS
   - Đôi khi VS cache gây vấn đề

2. **Check NuGet Packages**
   - **Tools → NuGet Package Manager → Restore NuGet Packages**
   - Restore cho toàn bộ solution

3. **Update .NET Framework**
   - Right-click solution → **Properties**
   - Kiểm tra **Target framework** là v4.8

4. **Manual DLL Copy**
   ```cmd
   # Từ command prompt:
   copy DTO\bin\Debug\*.dll GUI\bin\Debug\
   copy DAL\bin\Debug\*.dll GUI\bin\Debug\
   copy BUS\bin\Debug\*.dll GUI\bin\Debug\
   ```

## 📋 Checklist trước khi chạy:

- [ ] **Configuration**: Debug
- [ ] **Platform**: Any CPU/x64
- [ ] **References**: DTO, DAL, BUS đã add
- [ ] **Build order**: DTO → DAL → BUS → GUI
- [ ] **Output Window**: No errors (chỉ warnings OK)
- [ ] **File exe**: Tồn tại trong GUI\bin\Debug\

## 🎯 Kết quả mong đợi:

Sau khi build thành công:
```
Build succeeded.
0 Error(s)
0 Warning(s) or some warnings (OK)
```

File `GUI.exe` sẽ xuất hiện và bạn có thể chạy ứng dụng!

## 🚑 Nếu vẫn gặp vấn đề:

**Liên hệ support với thông tin:**
- Visual Studio version
- .NET Framework version
- Lỗi cụ thể trong Output Window
- Screenshot nếu có thể

## ✅ Alternative: Sử dụng Build Script

Nếu Visual Studio vẫn gặp vấn đề, dùng file `build.bat`:

```cmd
# Chạy trong thư mục DUKA:
build.bat
```

Script sẽ tự động build theo thứ tự đúng.
