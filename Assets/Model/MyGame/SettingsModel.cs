using System;
namespace MyGame
{
    public class SettingsModel
    {
        private static object mutex = new();
        private static volatile SettingsModel model;

        /// <summary>
        /// ������� ��� ��������� ������������� ������� ������.
        /// ����� ��������� ������������ � ������ ������.
        /// </summary>
        /// <returns>������</returns>
        public static SettingsModel Get()
        {
            if (model == null)
            {
                lock (mutex)
                {
                    if (model == null)
                    {
                        model = new SettingsModel();
                    }
                }
            }
            return model;
        }

        private SettingsModel()
        {
            // �������� ��������
        }
    }
}
