﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSO2015
{
    class ArquivoBLL
    {
        public RelatorioDAL lerArquivo(string caminho)
        {
            ArquivoDAO arquivoDAO = new ArquivoDAO();
            //return null;
            return arquivoDAO.LerArquivo(caminho);
        }        
    }
}
