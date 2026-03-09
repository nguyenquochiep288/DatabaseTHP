// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_AspNetUsers
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP
{

    public class v_AspNetUsers : AspNetUsers
    {
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string MA_NHOMQUYEN { get; set; }

        public string NAME_NHOMQUYEN { get; set; }
    }
}
