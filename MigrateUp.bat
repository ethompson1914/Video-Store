.\packages\FluentMigrator.Tools.1.1.2.1\tools\AnyCPU\40\Migrate --conn "server=.\SQLEXPRESS;Trusted_Connection=yes;Integrated Security=true;Initial Catalog=lin" -provider sqlserver2008 --assembly Migrations\bin\Debug\Migrations.dll --task migrate:up