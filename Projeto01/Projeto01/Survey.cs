using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto01
{
    /// <sumary>
    /// Enquete.
    /// </sumary>
    class Survey : IStorable
    {
        /// <sumary>
        /// Dicionário que mapeia um Id de opção para uma opção.
        /// </sumary>
        private IDictionary<string, Option> options = new Dictionary<string, Option>();

        /// <sumary>
        /// Referencia objeto responsável por calcular os votos.
        /// </sumary>
        private Votes votes;

        /// <sumary>
        /// Questão da Enquete.
        /// </sumary>
        public string Question { get; set; }

        /// <sumary>
        /// Contador de voto da enquete.
        /// </sumary>
        public int VoteCount {
            get
            {
                // delega a cotagem para o objeto responsável
                return votes.VoteCount;
            }
        }

        public Survey()
        {
            // instancia o objeto que calcula os votos
            votes = new Votes(this);
        }

        public void SetOption(string id, string text)
        {
            // Cria a opção, convertendo o ID para maiúsculo.
            Option option = new Option();
            option.Id = id.ToUpper();
            option.Text = text;

            if (!options.ContainsKey(id))
            {
                //Adiciona se o ID não existe.
                options.Add(id, option);
            }
            else
            {
                //Altera se ja existe.
                options[id] = option;
            }
        }

        /// <sumary>
        /// Retorna a enquete em um formato de string.
        /// </sumary>
        /// <returns>Enquete formatada.</returns>
        public string GetFormattedSurvey()
        {
            // Usa um StringBuilder para evitar concatenações de strings.
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Question);

            foreach (Option option in options.Values)
            {
                sb.Append(option.Id).Append(" - ").AppendLine(option.Text);
            }

            return sb.ToString();
        }
        //20MIN Da AULA
        public void Load(BinaryReader reader)
        {
            throw new NotImplementedException();
        }

        public void Save(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
