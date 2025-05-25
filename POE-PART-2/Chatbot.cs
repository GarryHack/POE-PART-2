using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_2
{
    internal class Chatbot
    {
        private string userName;
        private string userInterest;
        private Dictionary<string, List<string>> responses;
        private Dictionary<string, string> keywords;
        private Random random;

        public Chatbot() {
            random = new Random();
            InitializeResponses();
            InitializeKeywords();

        }
        private void InitializeResponses()
        {
            responses = new Dictionary<string, List<string>>
            {
                ["phishing"] = new List<string>
                {
                    "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations.",
                    "Always verify the sender's email address before clicking any links. When in doubt, contact the organization directly.",
                    "Look out for urgent language like 'Act now!' or 'Limited time offer!' - these are common phishing tactics.",
                    "Never provide passwords or sensitive information via email. Legitimate companies won't ask for this information.",
                    "Check for spelling errors and poor grammar - these are often signs of phishing attempts."
                },
                ["password"] = new List<string>
                {
                    "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.",
                    "Consider using a password manager to generate and store complex passwords securely.",
                    "Use a combination of uppercase, lowercase, numbers, and symbols for stronger passwords.",
                    "Change your passwords regularly, especially if you suspect they've been compromised.",
                    "Enable two-factor authentication whenever possible for an extra layer of security."
                },
                ["scam"] = new List<string>
                {
                    "Be skeptical of unsolicited calls or messages asking for money or personal information.",
                    "Research any investment opportunities thoroughly before committing your money.",
                    "Never give out your banking details to someone who contacts you unexpectedly.",
                    "If something sounds too good to be true, it probably is. Trust your instincts.",
                    "Verify the identity of anyone claiming to be from a company or government agency."
                },
                ["privacy"] = new List<string>
                {
                    "Review your social media privacy settings regularly to control who can see your information.",
                    "Be mindful of what personal information you share online - it can be used against you.",
                    "Use privacy-focused browsers and search engines to limit data collection.",
                    "Read privacy policies before agreeing to terms and conditions on websites and apps.",
                    "Consider using a VPN when browsing on public Wi-Fi networks."
                },
                  ["software updates"] = new List<string>
                {
                    "Regularly updating software plays an important role in protecting your data.",
                    "Outdated software often contains vulnerabilities that can be exploited by malicious actors to gain access to systems and data.",
                    "Software updates often include patches that address known vulnerabilities.",
                    "Updates may introduce new security features or enhancements that can strengthen your system’s defenses",
                    "Keeping software up to date helps to mitigate the risks associated with using outdated technology."
                },
                 ["Session hijacking"] = new List<string>
                {
                    "Make sure that your website uses HTTPS to encrypt data transmitted between your site and the users. ",
                    "Logging out of websites after you are done is important because once you log out, the session ID is invalid and cannot be used maliciously.",
                    "Many session hijacking attacks take advantage of stolen credentials; however, with MFA even if cybercriminals get your login credentials, they won’t be able to access your account without the second authentication requirement. ",
                    "Before clicking on a link, make sure that it is safe to do so. Some links may look legitimate but instead of taking you to the website you’re looking for, they may direct you to a malicious phishing site that’s trying to get you to enter your password or install malware.",
                    "Public WiFi isn’t secure, and it’s easy for cybercriminals to hijack sessions through Man-in-the-Middle attacks. If possible, avoid public WiFi completely."
                }
                
            };
        }
        private void InitializeKeywords()
        {
            keywords = new Dictionary<string, string>
            {
                ["password"] = "password",
                ["passwords"] = "password",
                ["login"] = "password",
                ["phishing"] = "phishing",
                ["phish"] = "phishing",
                ["email"] = "phishing",
                ["scam"] = "scam",
                ["scams"] = "scam",
                ["fraud"] = "scam",
                ["fraudulent"] = "scam",
                ["privacy"] = "privacy",
                ["private"] = "privacy",
                ["personal"] = "privacy",
                ["data"] = "privacy"
            };
        }

    }
}
