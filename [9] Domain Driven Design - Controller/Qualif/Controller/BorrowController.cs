using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qualif.Handler;
using Qualif.Model;

namespace Qualif.Controller
{
    public class BorrowController
    {

        BorrowHandler borrowHandler = new BorrowHandler();

        public string borrowValidation(DateTime date, int userId, int bookId)
        {
            if(date == DateTime.MinValue)
            {
                return "Tanggal Harus Diisi";
            }else if(date < DateTime.Now)
            {
                return "Tanggal Harus dipilih setelah hari ini";
            }
            else
            {
                borrowHandler.userBorrow(DateTime.Now, userId, date, bookId);
                return "";
            }
        }

        public List<JoinBookAndDetail> GetJoin(int id)
        {
            return borrowHandler.getBorrowBookAndDetailList(id);
        }

        public void returnBook(int detailId, int bookId)
        {
            borrowHandler.deleteBorrowDetail(detailId, bookId);
        }

    }
}