﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Models;

public partial class tb_usuario
{
    [Key]
    public int usu_id_usuario { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string usu_login { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string usu_senha { get; set; }

    public DateTime usu_data_criacao { get; set; }

    public DateTime? usu_ultimo_login { get; set; }

    public bool? usu_status { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string usu_cargo { get; set; }

    public DateTime? usu_bloqueado_ate { get; set; }

    public bool? usu_bloqueado { get; set; }

    public byte[] usu_imagem_perfil { get; set; }
}