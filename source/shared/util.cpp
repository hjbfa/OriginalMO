/*
Copyright (C) 2012 Sebastian Herbord. All rights reserved.

This file is part of Mod Organizer.

Mod Organizer is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Mod Organizer is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Mod Organizer.  If not, see <http://www.gnu.org/licenses/>.
*/

#include "util.h"
#include "windows_error.h"
#include "error_report.h"

#include <sstream>
#include <locale>
#include <algorithm>
#include <DbgHelp.h>
#include <set>
#include <boost/scoped_array.hpp>

namespace MOShared {


bool FileExists(const std::string &filename)
{
  DWORD dwAttrib = ::GetFileAttributesA(filename.c_str());

  return (dwAttrib != INVALID_FILE_ATTRIBUTES);
}

bool FileExists(const std::wstring &filename)
{
  DWORD dwAttrib = ::GetFileAttributesW(filename.c_str());

  return (dwAttrib != INVALID_FILE_ATTRIBUTES);
}

bool FileExists(const std::wstring &searchPath, const std::wstring &filename)
{
  std::wstringstream stream;
  stream << searchPath << "\\" << filename;
  return FileExists(stream.str());
}

std::string ToString(const std::wstring &source, bool utf8)
{
  std::string result;
  if (source.length() > 0) {
    UINT codepage = CP_UTF8;
    if (!utf8) {
      codepage = AreFileApisANSI() ? GetACP() : GetOEMCP();
    }
    int sizeRequired = ::WideCharToMultiByte(codepage, 0, &source[0], -1, nullptr, 0, nullptr, nullptr);
    if (sizeRequired == 0) {
      throw windows_error("failed to convert string to multibyte");
    }
    // the size returned by WideCharToMultiByte contains zero termination IF -1 is specified for the length.
    // we don't want that \0 in the string because then the length field would be wrong. Because madness
    result.resize(sizeRequired - 1, '\0');
    ::WideCharToMultiByte(codepage, 0, &source[0], (int)source.size(), &result[0], sizeRequired, nullptr, nullptr);
  }

  return result;
}

std::wstring ToWString(const std::string &source, bool utf8)
{
  std::wstring result;
  if (source.length() > 0) {
    UINT codepage = CP_UTF8;
    if (!utf8) {
      codepage = AreFileApisANSI() ? GetACP() : GetOEMCP();
    }
    int sizeRequired = ::MultiByteToWideChar(codepage, 0, source.c_str(), source.length(), nullptr, 0);
    if (sizeRequired == 0) {
      throw windows_error("failed to convert string to wide character");
    }
    result.resize(sizeRequired, L'\0');
    ::MultiByteToWideChar(codepage, 0, source.c_str(), source.length(), &result[0], sizeRequired);
  }

  return result;
}

static std::locale loc("");
static auto locToLowerW = [] (wchar_t in) -> wchar_t {
  return std::tolower(in, loc);
};

static auto locToLower = [] (char in) -> char {
  return std::tolower(in, loc);
};

std::string &ToLower(std::string &text)
{
  std::transform(text.begin(), text.end(), text.begin(), locToLower);
  return text;
}

std::string ToLower(const std::string &text)
{
  std::string result(text);
  std::transform(result.begin(), result.end(), result.begin(), locToLower);
  return result;
}

std::wstring &ToLower(std::wstring &text)
{
  std::transform(text.begin(), text.end(), text.begin(), locToLowerW);
  return text;
}

std::wstring ToLower(const std::wstring &text)
{
  std::wstring result(text);
  std::transform(result.begin(), result.end(), result.begin(), locToLowerW);
  return result;
}

bool CaseInsenstiveComparePred(wchar_t lhs, wchar_t rhs)
{
  return std::tolower(lhs, loc) == std::tolower(rhs, loc);
}

bool CaseInsensitiveEqual(const std::wstring &lhs, const std::wstring &rhs)
{
  return (lhs.length() == rhs.length())
      && std::equal(lhs.begin(), lhs.end(),
                    rhs.begin(),
                    [] (wchar_t lhs, wchar_t rhs) -> bool {
                      return std::tolower(lhs, loc) == std::tolower(rhs, loc);
                    });
}

VS_FIXEDFILEINFO GetFileVersion(const std::wstring &fileName)
{
  DWORD handle = 0UL;
  DWORD size = ::GetFileVersionInfoSizeW(fileName.c_str(), &handle);
  if (size == 0) {
    throw windows_error("failed to determine file version info size");
  }

  boost::scoped_array<char> buffer(new char[size]);
  try {
    handle = 0UL;
    if (!::GetFileVersionInfoW(fileName.c_str(), handle, size, buffer.get())) {
      throw windows_error("failed to determine file version info");
    }

    void *versionInfoPtr = nullptr;
    UINT versionInfoLength = 0;
    if (!::VerQueryValue(buffer.get(), L"\\", &versionInfoPtr, &versionInfoLength)) {
      throw windows_error("failed to determine file version");
    }

    VS_FIXEDFILEINFO result = *(VS_FIXEDFILEINFO*)versionInfoPtr;
    return result;
  } catch (...) {
    throw;
  }
}


} // namespace MOShared
