#ByteETA - Download Time Calculator

This is my first C# project! It calculates how long it would take to download a file based on your internet speed.

## 📸 ScreenShot
![Sample Output](images/screenshot.png)

# ByteETA Download Calculator - Release Notes

## v1.2 - 18.07.2025  
### 🔄 Changed  
- Replaced manual time calculation logic with `TimeSpan` for improved accuracy and readability of download time.

### ✨ Added  
- Prompt asking users if they want to perform another calculation without restarting the application.

## v1.1 - 17.07.2025
### 🛠️ Fixed
- Critical calculation errors in download time estimation
- Recursive method call risks
- File size conversion logic

### ⚡ Improved
- Input validation for both speed and file size
- Variable naming and code structure
- User feedback messages

### 🔄 Changed
- Math operations order for better accuracy
- Unit conversion approach
- Error handling mechanism

## v1.0 - 15.07.2025
### 🎉 Initial Release
- Basic download time calculation
- Supports speed units: Kbps, Mbps, Gbps
- Supports file size units: KB, MB, GB
- Console-based interface

## 💡 Note  
Since this is my first C# project, there may be some bugs or things that could be improved.  
Feel free to share any feedback or suggestions!

## 📜 License  
This project is licensed under the MIT License.  
For more details, see the [LICENSE](LICENSE) file.
