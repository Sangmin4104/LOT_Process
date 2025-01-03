using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT_PROCESS
{
    internal class DBConnector
    {
        private static string DbSource = "192.168.114.52,1433"; // DESKTOP-S7DM4I7 가능
        private static string DbName = "Lot_Process";
        private static string DbUser = "sa";
        private static string DbPassword = "12345";

        private static string connectionString;

        static DBConnector()
        {
            connectionString = $"Data Source={DbSource};" +
                                $"Initial Catalog={DbName};" +
                                $"User ID={DbUser};" +
                                $"Password={DbPassword};";

        }
        public List<string> GetLotProcessData()
        {
            List<string> lotProcessData = new List<string>();

            // 데이터베이스 연결
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT LOT_NO, WORK_TICKET, EQUIP_NAME, PART_NAME, EMP_NAME, QTY FROM TB_LOT_PROCESS";

                // SQL 쿼리 실행
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // 결과 읽기
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // 결과에서 데이터 읽기
                        while (reader.Read())
                        {
                            // 각 열의 데이터 가져오기
                            string lotNo = reader.GetString(0);
                            string workTicket = reader.GetString(1);
                            string equipName = reader.GetString(2);
                            string partName = reader.GetString(3);
                            string empName = reader.GetString(4);
                            int qty = reader.GetInt32(5);

                            // 각 행의 데이터를 하나의 문자열로 조합하여 리스트에 추가
                            string processData = $"{lotNo}, {workTicket}, {equipName}, {partName}, {empName}, {qty}";
                            lotProcessData.Add(processData);
                        }
                    }
                }
            }
            return lotProcessData;
        }
        public List<string> GetProcNames()
        {
            List<string> procNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PROC_NAME FROM TB_LOT_PROCESS";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string procName = reader.GetString(0);

                            procNames.Add(procName);
                        }
                    }
                }
            }
            return procNames;
        }
        public List<string> GetLotDetailData(string lotNo)
        {
            List<string> lotProcessData = new List<string>();

            // 데이터베이스 연결
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT B.LOT_ID, A.LOT_NO, B.WORK_NAME, A.WORK_TICKET, A.PROC_NAME, A.EQUIP_NAME, A.PART_NAME, A.QTY,  B.SAVE_BY, B.SAVE_DTTM FROM TB_LOT_PROCESS A, TB_WORK_HISTORY B WHERE A.LOT_NO = B.LOT_NO AND B.LOT_NO = @lotNo";

                // SQL 쿼리 실행
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@lotNo", lotNo);
                    connection.Open();

                    // 결과 읽기
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 각 열의 데이터 가져오기
                            int lotId = reader.GetInt32(0);
                            string lot_No = reader.GetString(1);
                            string workName = reader.GetString(2);
                            string workTicket = reader.GetString(3);
                            string procName = reader.GetString(4);
                            string equipName = reader.GetString(5);
                            string partName = reader.GetString(6);
                            int qty = reader.GetInt32(7);
                            string saveBy = reader.GetString(8);
                            DateTime saveDttm = reader.GetDateTime(9);
                            
                            string processData = $"{lotId}, {lot_No}, {workName}, {workTicket}, {procName}, {equipName}, {partName},  {saveBy}, {saveDttm}, {qty}";
                            lotProcessData.Add(processData);
                        }
                    }
                }
            }
            return lotProcessData;
        }

        public List<string> BOM_Procedure(string lotNo, int checkd_id)
        {
            List<string> lotProcessData = new List<string>();

            // 프로시저 이름
            string procedureName = "sp_BOM";

            // 데이터베이스 연결 및 프로시저 호출
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    // CommandType 설정
                    command.CommandType = CommandType.StoredProcedure;

                    // 파라미터 추가
                    command.Parameters.AddWithValue("@StartLOT_NO", lotNo);
                    command.Parameters.AddWithValue("@Explosion", checkd_id);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // 각 열의 데이터 가져오기
                                int lotId = reader.GetInt32(0);
                                string lot_No = reader.GetString(1);
                                string historyLot_No = reader.GetString(2);
                                int level = reader.GetInt32(3);
                                string workName = reader.GetString(4);
                                string saveBy = reader.GetString(5);
                                DateTime saveDttm = reader.GetDateTime(6);

                                string processData = $"{lotId}, {lot_No}, {historyLot_No}, {level}, {workName}, {saveBy}, {saveDttm}";
                                lotProcessData.Add(processData);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error executing stored procedure: " + ex.Message);
                    }
                }
            }
            return lotProcessData;
        }
    }
}
