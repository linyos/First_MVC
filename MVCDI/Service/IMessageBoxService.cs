using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDI.Service
{
   public interface IMessageBoxService
    {
        void ShowError(string message);


        /// <summary>
        /// 顯示訊息
        /// </summary>
        /// <param name="message">訊息</param>
        void ShowInformation(string message);
        
        /// <summary>
        /// 詢問訊息
        /// </summary>
        /// <param name="message">訊息</param>
        /// <returns></returns>
        bool ShowQuestion(string message);


        /// <summary>
        /// 詢問訊息
        /// </summary>
        /// <param name="message">訊息</param>
        /// <returns></returns>
        DialogResult ShowQuestionCancel(string message);


        /// <summary>
        /// 顯示警告訊息
        /// </summary>
        /// <param name="message">警告訊息</param>
        void ShowWarning(string message);
      
    }
}
