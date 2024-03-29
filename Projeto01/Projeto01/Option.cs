﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Projeto01
{
    /// <sumary>
    /// Opção de uma enquete.
    /// </sumary>
    class Option :IStorable, IEquatable<Option>
    {
        /// <sumary>
        /// Id da opção (O que deve ser digitado para escolher a opção).
        /// </sumary>
        public string Id { get; set; }

        /// <sumary>
        /// Texto associado à opção.
        /// </sumary>
        public string Text { get; set; }

        public void Save(BinaryWriter writer)
        {
            writer.Write(Id);
            writer.Write(Text);
        }

        public void Load(BinaryReader reader)
        {
            Id = reader.ReadString();
            Text = reader.ReadString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Option); 
        }

        public bool Equals(Option other)
        {
            if (other == null) {
                return false;
            }
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }
}
