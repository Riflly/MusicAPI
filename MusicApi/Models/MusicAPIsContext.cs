using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MusicApi.Models
{
    public partial class MusicAPIsContext : DbContext
    {
        public MusicAPIsContext()
        {
        }

        public MusicAPIsContext(DbContextOptions<MusicAPIsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> TblAlbum { get; set; }
        public virtual DbSet<AlbumPicture> TblAlbumPicture { get; set; }
        public virtual DbSet<Artist> TblArtist { get; set; }
        public virtual DbSet<ArtistPicture> TblArtistPicture { get; set; }
        public virtual DbSet<GenreCategory> TblGenreCategory { get; set; }
        public virtual DbSet<PlaylistItem> TblPlaylistItem { get; set; }
        public virtual DbSet<Song> TblSong { get; set; }
        public virtual DbSet<SongData> TblSongData { get; set; }
        public virtual DbSet<User> TblUser { get; set; }
        public virtual DbSet<UserPlaylist> TblUserPlaylist { get; set; }
        public virtual DbSet<Role> TblRole { get; set; }
        public virtual DbSet<UserRole> TblUserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=MusicAPIs");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.AlbumId);

                entity.ToTable("tblAlbum");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.AlbumName).HasMaxLength(60);

                entity.Property(e => e.AlbumPictureId).HasColumnName("AlbumPictureID");

                entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.HasOne(d => d.AlbumPicture)
                    .WithMany(p => p.TblAlbum)
                    .HasForeignKey(d => d.AlbumPictureId)
                    .HasConstraintName("FK__tblAlbum__AlbumP__30F848ED");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.TblAlbum)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__tblAlbum__Artist__300424B4");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.TblAlbum)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__tblAlbum__GenreI__2F10007B");
            });

            modelBuilder.Entity<AlbumPicture>(entity =>
            {
                entity.HasKey(e => e.AlbumPictureId);

                entity.ToTable("tblAlbumPicture");

                entity.Property(e => e.AlbumPictureId).HasColumnName("AlbumPictureID");

                entity.Property(e => e.PictureOne).IsRequired();
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.ArtistId);

                entity.ToTable("tblArtist");

                entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

                entity.Property(e => e.ArtistBio).HasColumnType("text");

                entity.Property(e => e.ArtistName).HasMaxLength(40);

                entity.Property(e => e.ArtistPictureId).HasColumnName("ArtistPictureID");

                entity.HasOne(d => d.ArtistPicture)
                    .WithMany(p => p.TblArtist)
                    .HasForeignKey(d => d.ArtistPictureId)
                    .HasConstraintName("FK__tblArtist__Artis__25869641");
            });

            modelBuilder.Entity<ArtistPicture>(entity =>
            {
                entity.HasKey(e => e.ArtistPictureId);

                entity.ToTable("tblArtistPicture");

                entity.Property(e => e.ArtistPictureId).HasColumnName("ArtistPictureID");
            });

            modelBuilder.Entity<GenreCategory>(entity =>
            {
                entity.HasKey(e => e.GenreId);

                entity.ToTable("tblGenreCategory");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.GenreName).HasMaxLength(40);
            });

            modelBuilder.Entity<PlaylistItem>(entity =>
            {
                entity.HasKey(e => e.PlaylistItemId);

                entity.ToTable("tblPlaylistItem");

                entity.Property(e => e.PlaylistItemId).HasColumnName("PlaylistItemID");

                entity.Property(e => e.PlaylistId).HasColumnName("PlaylistID");

                entity.Property(e => e.SongId).HasColumnName("SongID");

                entity.HasOne(d => d.Playlist)
                    .WithMany(p => p.TblPlaylistItem)
                    .HasForeignKey(d => d.PlaylistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblPlayli__Playl__3C69FB99");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.TblPlaylistItem)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblPlayli__SongI__3D5E1FD2");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasKey(e => e.SongId);

                entity.ToTable("tblSong");

                entity.Property(e => e.SongId).HasColumnName("SongID");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.SongDataId).HasColumnName("SongDataID");

                entity.Property(e => e.SongName).HasMaxLength(60);

                entity.Property(e => e.VideoLink).HasColumnType("text");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.TblSong)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblSong__AlbumID__36B12243");

                entity.HasOne(d => d.SongData)
                    .WithMany(p => p.TblSong)
                    .HasForeignKey(d => d.SongDataId)
                    .HasConstraintName("FK__tblSong__SongDat__35BCFE0A");
            });

            modelBuilder.Entity<SongData>(entity =>
            {
                entity.HasKey(e => e.SongDataId);

                entity.ToTable("tblSongData");

                entity.Property(e => e.SongDataId).HasColumnName("SongDataID");

                entity.Property(e => e.Data).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.City).HasColumnType("text");

                entity.Property(e => e.Country).HasColumnType("text");

                entity.Property(e => e.FavGenreId).HasColumnName("FavGenreID");

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(40);

                entity.Property(e => e.UserPasswordHash).HasColumnType("text");

                entity.HasOne(d => d.FavGenre)
                    .WithMany(p => p.TblUser)
                    .HasForeignKey(d => d.FavGenreId)
                    .HasConstraintName("FK__tblUser__FavGenr__2A4B4B5E");
            });

            modelBuilder.Entity<UserPlaylist>(entity =>
            {
                entity.HasKey(e => e.PlaylistId);

                entity.ToTable("tblUserPlaylist");

                entity.Property(e => e.PlaylistId).HasColumnName("PlaylistID");

                entity.Property(e => e.PlaylistDesc).HasColumnType("text");

                entity.Property(e => e.PlaylistName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserPlaylist)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tblUserPl__UserI__398D8EEE");
            });
        }
    }
}
