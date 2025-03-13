<?php
session_start();

if (!isset($_SESSION['zoo_data'])) {
    die("Дані відсутні. Спочатку відвідайте <a href='animal.php'>головну сторінку</a>.");
}

$data = $_SESSION['zoo_data'];

$animal_count = count($data['animals']);
$employee_count = count($data['employees']);
?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Звіт про зоопарку</title>
    <link rel="stylesheet" href="report.css"/>
</head>
<body>
    <h1>Звіт по зоопарку</h1>

    <h2>Кількість тварин: <?= $animal_count ?></h2>
    <h2>Кількість працівників: <?= $employee_count ?></h2>

    <h2>Стан запасів їжі</h2>
    <ul>
        <?php foreach ($data['food'] as $item): ?>
            <li><?= $item['name'] ?> (<?= $item['type'] ?>): <?= $item['quantity'] ?> кг, придатність до <?= $item['expiration_date'] ?></li>
        <?php endforeach; ?>
    </ul>

    <div>
    <a href="animal.php">Назад до зоопарку</a>
    </div>
</body>
</html>
