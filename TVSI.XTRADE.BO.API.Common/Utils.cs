using System.Collections;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TVSI.XTRADE.BO.API.Common;

public static class Utils
{
    public static bool IsList(this object? o)
    {
        if (o == null) return false;
        return o is IList &&
               o.GetType().IsGenericType &&
               o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
    }

    public static string ErrorCodeFormat(this int errCode)
    {
        return !string.IsNullOrEmpty(CommonConstants.ErrPrefix)
            ? errCode != 0 ? $"{CommonConstants.ErrPrefix}-{errCode}" : errCode.ToString()
            : errCode.ToString();
    }

    public static string Utf8Convert(this string s)
    {
        var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        var temp = s.Normalize(NormalizationForm.FormD);
        return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
    }

    public static string ReplaceWhitespace(this string input, string replacement = "")
    {
        var sWhitespace = new Regex(@"\s+");
        return sWhitespace.Replace(input, replacement);
    }

    public static string ReplaceSpecialCharacter(this string input, string replacement = "_")
    {
        var specialChar = new Regex(@"[~`!@#$%^&*()+={[}\]|':;<,>.?/-]");
        return specialChar.Replace(input, replacement);
    }

    public static string UpdateFileJson(string filePath, string[] pathKeys, string[] arrVal)
    {
        var jsonString = File.ReadAllText(filePath);
        var jObject = JsonConvert.DeserializeObject(jsonString) as JObject;
        for (var i = 0; i < pathKeys.Length; i++)
        {
            var jToken = jObject?.SelectToken(pathKeys[i]);
            jToken?.Replace(arrVal[i]);
        }

        var updatedJsonString = jObject?.ToString();
        return updatedJsonString ?? string.Empty;
    }

    public static string GetMessageDbEntityValidationException(this DbEntityValidationException e)
    {
        return e.EntityValidationErrors.Aggregate(string.Empty, (current1, eve)
            => eve.ValidationErrors.Aggregate(current1, (current, ve)
                => current + "- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage + ", "));
    }

    public static string Md5EncodePassword(this string? originalPassword)
    {
        return BitConverter.ToString(
            new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(originalPassword ?? string.Empty)));
    }

    public static string? ConvertToDateString(this string? dateString, string dateFormatIn = "yyyyMMdd",
        string dateFormatOut = "dd/MM/yyyy")
    {
        if(dateString == null) return null;
        var d = DateTime.ParseExact(dateString, dateFormatIn, CultureInfo.InvariantCulture);
        return d.ToString(dateFormatOut);
    }

    public static string ConvertDateToDateString(this DateTime d, string dateFormatOut = "dd/MM/yyyy")
    {
        return d.ToString(dateFormatOut);
    }
}