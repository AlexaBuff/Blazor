using Blazorise;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class CheckCol
    {

      

       static public void CheckF(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
             
            }
            else
            {

               bool ruleNumeric = ValidationRule.IsLength(validationArgs.Value.ToString(), 0, 30);

                if (ruleNumeric)
                { 
                    validationArgs.Status = ValidationStatus.Success;
                   
                }
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся не более 30 символов.";
                   
                }

            }
        }
        static public void CheckI(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
              
            }
            else
            {
                bool ruleNumeric = ValidationRule.IsLength(validationArgs.Value.ToString(), 0, 20);

                if (ruleNumeric)
                {
                    validationArgs.Status = ValidationStatus.Success;
                  
                }
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся не более 20 символов.";
                 
                }

            }
        }
        static public void CheckO(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                bool ruleNumeric = ValidationRule.IsLength(validationArgs.Value.ToString(), 0, 20);

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся не более 20 символов.";
                }

            }
        }

        static public void CheckAdr(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                bool ruleNumeric = ValidationRule.IsLength(validationArgs.Value.ToString(), 0, 255);

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся не более 255 цифр.";
                }

            }
        }

        static public void CheckPasV (ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                bool ruleNumeric = ValidationRule.IsLength(validationArgs.Value.ToString(), 0, 100);

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся не более 100 цифр.";
                }

            }
        }

        static public void CheckPolis(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                Regex regex = new Regex(@"^$|^\d{16}$");
                bool ruleNumeric = regex.IsMatch(validationArgs.Value.ToString());

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся 16 цифр.";
                }

            }
        }

        static public void CheckPasS(ValidatorEventArgs validationArgs)
        {

            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                Regex regex = new Regex(@"^$|^\d{4}$");
                bool ruleNumeric = regex.IsMatch(validationArgs.Value.ToString());

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся 4 цифры.";
                }
             
            }

        }

        static public void CheckPasN(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                Regex regex = new Regex(@"^$|^\d{6}$");
                bool ruleNumeric = regex.IsMatch(validationArgs.Value.ToString());

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводятся 6 цифр.";
                }

            }
        }


        static public void CheckTel(ValidatorEventArgs validationArgs)
        {
            if (String.IsNullOrWhiteSpace(validationArgs.Value.ToString()))
            {
                validationArgs.Status = ValidationStatus.None;
            }
            else
            {
                Regex regex = new Regex(@"^\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{4}?\)??-?$");
                bool ruleNumeric = regex.IsMatch(validationArgs.Value.ToString());

                if (ruleNumeric) validationArgs.Status = ValidationStatus.Success;
                else
                {
                    validationArgs.Status = ValidationStatus.Error;
                    validationArgs.ErrorText = "В поле вводится телефон в формате XXX-XXX-XXXX";
                }

            }
        }

    }
}
