# Caesar Cipher in C# 🔐

![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/Framework-.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge)

A simple console application written in C# that encrypts text using the classic **Caesar Cipher** algorithm. This project was created by [Kaaner4mir](https://github.com/Kaaner4mir).

## 📖 About the Project

The Caesar Cipher is one of the simplest and most widely known encryption techniques. It is a type of substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet. 

This program prompts the user to enter a **shift key** (an integer) and a **plaintext message**. It will then shift the alphabetical characters by the key specified and output the **ciphertext**.

### ✨ Features
* **Custom Shift Key:** Users can specify any integer value for the key. (Positive or negative shifts are supported through modulo arithmetic).
* **Case Preservation:** Uppercase letters remain uppercase, and lowercase letters remain lowercase.
* **Non-Alphabetical Characters:** Spaces, numbers, and symbols are left entirely unchanged.

## 🚀 Getting Started

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Installation & Execution

1. Clone the repository:
   ```bash
   git clone https://github.com/Kaaner4mir/caesar.git
   ```
2. Navigate to the project directory:
   ```bash
   cd caesar/Caesar
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

## 💻 Example Usage

```console
Enter your key: 3
plaintext:  Hello, World!
ciphertext: Khoor, Zruog!
```

```console
Enter your key: 13
plaintext:  C# is Awesome!!!
ciphertext: P# vf Njrfbzr!!!
```

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](https://github.com/Kaaner4mir/caesar/issues) if you want to contribute.

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---
*Created with ❤️ by [Kaaner4mir](https://github.com/Kaaner4mir)*
